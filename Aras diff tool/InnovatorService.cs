using Aras.IOM;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ArasDiffTool
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
        public async Task<IEnumerable<Item>> GetItemsAsync(IEnumerable<string> itemTypes)
        {
            var ret = new List<Item>();
            foreach (var itemType in itemTypes)
            {
                var tmp = itemType.Trim().Replace(" ", "_");
                var items = Inn.newItem(tmp, "get");
                items = items.apply();
                if (items.isError())
                {
                    continue;
                }
                var c = items.getItemCount();
                for (int i = 0; i < c; i++)
                {
                    ret.Add(items.getItemByIndex(i));
                }
            }

            return ret;
        }
    }
}
