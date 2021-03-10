using Aras.IOM;
using InnoTool.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InnoTool.Services
{
    public class InnovatorService
    {
        public InnovatorService(ConnectionSettings connSettings)
        {
            ConnSettings = connSettings;
        }
        public ConnectionSettings ConnSettings { get; }

        protected Innovator _inn;
        protected Innovator Inn {
            get
            {
                if (_inn == null)
                {
                    _inn = IomFactory.CreateInnovator(
                        IomFactory.CreateHttpServerConnection(
                            ConnSettings.Url, 
                            ConnSettings.Database, 
                            ConnSettings.Username, 
                            ConnSettings.Password
                            )
                        );
                }

                return _inn;
            }
        }

        public bool TestConnectionSettings()
        {
            var ret = false;
            var conn = IomFactory.CreateHttpServerConnection(
                            ConnSettings.Url,
                            ConnSettings.Database,
                            ConnSettings.Username,
                            ConnSettings.Password
                );
            var res = conn.Login();
            if (res.isError())
            {
                throw new Exception(res.getErrorDetail());
            }
            else
            {
                ret = true;
            }

            return ret;
        }
        public IEnumerable<Item> GetItems(string type)
        {
            var ret = new List<Item>();
            try
            {
                var items = Inn.newItem(type, "get");
                items = items.apply();
                var c = items.getItemCount();
                for (int i = 0; i < c; i++)
                {
                    var tmpItem = items.getItemByIndex(i);
                    ret.Add(tmpItem);
                }
            }
            catch (Exception ex)
            {
            }

            return ret;
        }
        public IEnumerable<Item> GetItems(IEnumerable<ItemTypeSetting> itemTypes, DateTime? from = null, DateTime? to = null)
        {
            var ret = new List<Item>();

            try
            {
                var strings = new List<string>();
                foreach (var itemType in itemTypes)
                {
                    var nameField = itemType.Property.Trim().Replace("'", "''").Replace("[", "").Replace("]", "");
                    var type = itemType.ItemType.Trim().Replace("'", "''");
                    var tableName = type.Replace(" ", "_");
                    var str = $@"(
SELECT
[Id],
[{nameField}] AS [name],
'{type}' AS type,
CONVERT(NVARCHAR(30), [modified_on], 126) AS [modified_on],
CONVERT(NVARCHAR(30), [created_on], 126) AS [created_on]
FROM
    innovator.[{tableName}]
                    )";
                    strings.Add(str);
                }
                var sql = new StringBuilder("SELECT t.[Id], t.[Name], t.[type], t.[modified_on], t.[created_on], pd.name AS [package] FROM (");
                sql.AppendLine(string.Join(" UNION ALL ", strings));
                sql.AppendLine(") AS t ");
                sql.AppendLine(" LEFT JOIN innovator.PACKAGEELEMENT AS pe ON pe.[element_id] = t.[id] ");
                sql.AppendLine(" LEFT JOIN innovator.PACKAGEGROUP AS pg ON pg.[Id] = pe.[source_id] ");
                sql.AppendLine(" LEFT JOIN innovator.PACKAGEDEFINITION AS pd ON pd.[Id] = pg.[source_id] ");
                if (from.HasValue || to.HasValue)
                {
                    sql.AppendLine(" WHERE 1=1 ");
                    if (from.HasValue)
                    {
                        sql.AppendLine($" AND t.modified_on>='{from.Value.ToString("yyyy-MM-dd")}'");
                    }
                    if (to.HasValue)
                    {
                        sql.AppendLine($" AND t.modified_on<='{to.Value.ToString("yyyy-MM-dd")}'");
                    }
                }

                var items = Inn.applySQL(sql.ToString());
                if (items.isError())
                {
                    throw new Exception(items.getErrorDetail());
                }
                var c = items.getItemCount();
                for (int i = 0; i < c; i++)
                {
                    var tmpItem = items.getItemByIndex(i);
                    ret.Add(tmpItem);
                }
            }
            catch (Exception ex)
            {

                throw;
            }

            return ret;
        }

        public Innovator GetInnovator()
        {
            return _inn;
        }
    }
}
