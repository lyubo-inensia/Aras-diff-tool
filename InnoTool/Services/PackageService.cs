using Aras.IOM;
using InnoTool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoTool.Services
{
    public class PackageService : IPackageService
    {
        public PackageService(InnovatorService inn)
        {
            Inn = inn;
        }

        protected const string PackageDefinitionType = "PackageDefinition";
        public InnovatorService Inn { get; }

        private static IEnumerable<PackageDefinition> packageCache;
        public async Task<IEnumerable<PackageDefinition>> GetPackages()
        {
            if (packageCache != null)
            {
                return packageCache;
            }
            IEnumerable<PackageDefinition> ret = new List<PackageDefinition>();
            try
            {
                var packages = Inn.GetItems(PackageDefinitionType);
                ret = packages.Select(e => new PackageDefinition
                {
                    Id = e.getID(),
                    Name = e.getProperty("name")
                });
            }
            catch { }
            packageCache = ret;

            return ret;
        }

        protected List<Item> GetPackageGroups(string packId)
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
        protected Item CreatePackGroup(string packId, string type)
        {
            Item ret = null;
            try
            {
                ret = Inn.GetInnovator().newItem("packagegroup", "add");
                ret.setProperty("source_id", packId);
                ret.setProperty("name", type);
                ret = ret.apply();
                if (ret.isError())
                {
                    throw new Exception(ret.getErrorDetail());
                }
            }
            catch (Exception ex)
            {
                ret = null;
            }

            return ret;
        }
        protected bool RemoveItemFromPackages(string itemId)
        {
            var ret = false;
            try
            {
                var sql = $"DELETE FROM innovator.packageelement WHERE element_id='{itemId}'";
                Inn.GetInnovator().applySQL(sql);
            }
            catch (Exception ex)
            {
            }

            return ret;
        }
        public IEnumerable<IBaseItem> AddItemsToPackage(string packId, IEnumerable<IBaseItem> items, string packageName, bool moveItems = false)
        {
            List<IBaseItem> ret = new List<IBaseItem>();
            var groups = GetPackageGroups(packId);
            foreach (var item in items)
            {
                try
                {
                    var g = groups.FirstOrDefault(e => e.getProperty("name") == item.Type);
                    if (g == null)
                    {
                        g = CreatePackGroup(packId, item.Type);
                        if (g == null || g.isError())
                        {
                            continue;
                        }
                        groups.Add(g);
                    }

                    if (moveItems)
                    {
                        RemoveItemFromPackages(item.Id);
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
                        item.Package = packageName;
                        ret.Add(item);
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
                    if (packageCache != null)
                    {
                        packageCache.Concat(new List<PackageDefinition> { { ret} });
                    }
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
