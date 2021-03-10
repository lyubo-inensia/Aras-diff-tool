using Aras.IOM;
using InnoTool.Models;
using System;
using System.Collections.Generic;
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

        public async Task<bool> TestConnectionSettings()
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
        public async Task<IEnumerable<Item>> GetItemsAsync(string type)
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
        public async Task<IEnumerable<Item>> GetItemsAsync(IEnumerable<ItemTypeSetting> itemTypes)
        {
            var ret = new List<Item>();

            try
            {
                foreach (var itemType in itemTypes)
                {
                    var tmp = itemType.ItemType.Trim();
                    var items = Inn.newItem(tmp, "get");
                    items = items.apply();
                    if (items.isError())
                    {
                        continue;
                    }
                    var c = items.getItemCount();
                    for (int i = 0; i < c; i++)
                    {
                        var tmpItem = items.getItemByIndex(i);
                        tmpItem.setProperty("diff_name_prop", itemType.Property.Trim());
                        ret.Add(tmpItem);
                    }
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
