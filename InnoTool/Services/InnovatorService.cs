using Aras.IOM;
using InnoTool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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

        protected List<IBaseItem> PopulateDependencies(List<IBaseItem> allItems, IBaseItem item, List<string> visited)
        {
            List<IBaseItem> ret = new List<IBaseItem>();

            var deps = allItems.Where(e => e.ParentId == item.Id).Distinct();
            if (visited.Contains(item.Id)) {
                return ret;
            }

            visited.Add(item.Id);
            foreach (var d in deps)
            {
                d.Dependencies = PopulateDependencies(allItems, d, visited);
                if (!ret.Any(e => e.Id == d.Id)) {
                    ret.Add(d);
                }
            }

            return ret;
        }

        public IEnumerable<IBaseItem> GetDependencies(IBaseItem item)
        {
            return PopulateDependencies(GetDependencies(), item, new List<string>()); ;
        }
        public IEnumerable<IBaseItem> GetDependencies(IEnumerable<IBaseItem> items)
        {
            var ret = new List<IBaseItem>();
            foreach (var item in items.ToList())
            {
                item.Dependencies = GetDependencies(item);
                ret.Add(item);
            }

            return ret;
        }

        static Dictionary<int, List<IBaseItem>> depsCache = new Dictionary<int, List<IBaseItem>>();
        public List<IBaseItem> GetDependencies()
        {
            if (depsCache.ContainsKey(ConnSettings.GetHashCode()))
            {
                return depsCache[ConnSettings.GetHashCode()];
            }
            List<IBaseItem> ret = new List<IBaseItem>();
            var sql = $@"
SELECT it.[id], it.[name], it.[name] AS [type], pd.name AS [package], t.[parent_id] FROM
(
(
SELECT
	[SOURCE_ID] AS parent_id,
    [DATA_SOURCE] AS Id    
FROM
[innovator].[PROPERTY]
WHERE
[DATA_TYPE]='item'
)
UNION ALL
(
SELECT
	[SOURCE_ID] AS Id,
    [DATA_SOURCE] AS  parent_id   
FROM
[innovator].[PROPERTY]
WHERE
[DATA_TYPE]='item'
)
UNION ALL
(
SELECT
	[SOURCE_ID] AS Id ,
    [RELATED_ID] AS parent_id  
FROM
[innovator].[RELATIONSHIPTYPE]
)
UNION ALL
(
SELECT
	[SOURCE_ID] AS parent_id,
    [RELATED_ID] AS Id  
FROM
[innovator].[RELATIONSHIPTYPE]
)
UNION ALL
(
SELECT
	[SOURCE_ID] AS parent_id,
    [ID] AS Id  
FROM
[innovator].[PRESENTATIONCOMMANDBARSECTION]
)
UNION ALL
(
SELECT
	[SOURCE_ID] AS Id,
    [ID] AS parent_id
FROM
[innovator].[PRESENTATIONCOMMANDBARSECTION]
)

) AS t
INNER JOIN
[innovator].[ITEMTYPE] AS it
ON
it.[id]=t.[id]
";
            sql += " LEFT JOIN innovator.PACKAGEELEMENT AS pe ON pe.[element_id] = t.[id] ";
            sql += " LEFT JOIN innovator.PACKAGEGROUP AS pg ON pg.[Id] = pe.[source_id] ";
            sql += " LEFT JOIN innovator.PACKAGEDEFINITION AS pd ON pd.[Id] = pg.[source_id] ";
            var items = Inn.applySQL(sql.ToString());
            if (items.isError())
            {
                throw new Exception(items.getErrorDetail());
            }
            var c = items.getItemCount();
            for (int i = 0; i < c; i++)
            {
                var tmpItem = items.getItemByIndex(i);
                ret.Add(new SingleItem(tmpItem));
            }
            depsCache.Add(ConnSettings.GetHashCode(), ret);

            return ret;
        }
        public Innovator GetInnovator()
        {
            return Inn;
        }
    }
}
