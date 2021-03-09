using Aras.IOM;
using ArasDiffTool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArasDiffTool.Services
{
    public class PackageService
    {
        public PackageService(InnovatorService inn)
        {
            Inn = inn;
        }

        protected const string PackageDefinitionType = "PackageDefinition";
        public InnovatorService Inn { get; }

        public async Task<IEnumerable<PackageDefinition>> GetPackages()
        {
            IEnumerable<PackageDefinition> ret = new List<PackageDefinition>();
            try
            {
                var packages = await Inn.GetItemsAsync(PackageDefinitionType);
                ret = packages.Select(e => new PackageDefinition
                {
                    Id = e.getID(),
                    Name = e.getProperty("name")
                });
            }
            catch { }

            return ret;
        }

        public List<Item> GetPackageGroups(string packId)
        {
            List<Item> ret = new List<Item>(); ;
            try
            {
                var items = Inn.GetInnovator().newItem("packagegroup", "get");
                items.setProperty("source_id", packId);
                items = items.apply();
                for (int i = 0; i < items.getItemCount(); i++)
                {
                    ret.Add(items.getItemByIndex(i));
                }
            }
            catch { }

            return ret;
        }
        public Dictionary<string, string> GetItemTypes()
        {
            Dictionary<string, string> ret = new Dictionary<string, string>(); ;
            try
            {
                var items = Inn.GetInnovator().newItem("itemtype", "get");
                items = items.apply();
                for (int i = 0; i < items.getItemCount(); i++)
                {
                    ret.Add(items.getItemByIndex(i).getProperty("name").ToLower(), items.getItemByIndex(i).getID());
                }
            }
            catch { }

            return ret;
        }
        protected Item CreatePackGroup(string packId, string type)
        {
            Item ret = null;
            try
            {
                ret = Inn.GetInnovator().newItem("packagegroup", "add");
                ret.setProperty("source_id", packId);
                ret.setProperty("name", type);
                ret = ret.apply();
            }
            catch (Exception ex)
            {
                ret = null;
            }

            return ret;
        }
        public int AddItemToPackage(string packId, IEnumerable<IBaseItem> items)
        {
            var ret = 0;
            var groups = GetPackageGroups(packId);
            foreach (var item in items)
            {
                try
                {
                    var g = groups.FirstOrDefault(e => e.getProperty("name") == item.Type);
                    if (g == null)
                    {
                        g = CreatePackGroup(packId, item.Type);
                        if (g == null)
                        {
                            continue;
                        }
                        groups.Add(g);
                    }
                    var newItem = Inn.GetInnovator().newItem("packageelement", "add");
                    var groupId = g.getID();
                    newItem.setProperty("element_id", item.Id);
                    newItem.setProperty("source_id", groupId);
                    newItem.setProperty("element_type", item.Type);
                    newItem.setProperty("name", item.Name);
                    newItem = newItem.apply();
                    if (!newItem.isError()) 
                    {
                        ret++;
                    }
                }
                catch (Exception ex)
                {
                }
            }

            return ret;
        }
        public PackageDefinition AddPackage(string name)
        {
            PackageDefinition ret = null;
            try
            {
                var item = Inn.GetInnovator().newItem(PackageDefinitionType, "add");
                item.setProperty("name", name);
                item = item.apply();
                if (!item.isError())
                {
                    ret = new PackageDefinition { Id = item.getID(), Name = item.getProperty("name") };
                }
            }
            catch (Exception ex)
            {

                throw;
            }

            return ret;
        }
    }
}
