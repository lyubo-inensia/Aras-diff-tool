using Aras.IOM;
using InnoTool.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InnoTool.Services
{
    public class DiffService : IDiffService
    {
        public IEnumerable<DiffItem> CompareItems(IEnumerable<Item> items1, IEnumerable<Item> items2)
        {
            List<DiffItem> ret = new List<DiffItem>();
            List<string> names = new List<string>();
            var data1 = ItemsToDictionary(items1);
            var data2 = ItemsToDictionary(items2);

            names.AddRange(data1.Keys);
            names.AddRange(data2.Keys);
            foreach (var name in names.Distinct())
            {
                if (data1.ContainsKey(name) &&
                    !data2.ContainsKey(name))
                {

                    var tmp = new DiffItem(data1[name], null) { ChangeType = ItemChangeType.Created };
                    ret.Add(tmp);
                }
                else if (!data1.ContainsKey(name) &&
                    data2.ContainsKey(name))
                {

                    var tmp = new DiffItem(null, data2[name]) { ChangeType = ItemChangeType.Deleted };
                    ret.Add(tmp);
                }
                else if (data1.ContainsKey(name) &&
                    data2.ContainsKey(name))
                {
                    var tmp = new DiffItem(data1[name], data2[name]) { ChangeType = ItemChangeType.Modified };
                    if (tmp.ModifiedDate1 != tmp.ModifiedDate2)
                    {
                        ret.Add(tmp);
                    }
                }
            }

            return ret;
        }



        public IEnumerable<SingleItem> ListItems(IEnumerable<Item> items1)
        {
            List<SingleItem> ret = new List<SingleItem>();
            List<string> names = new List<string>();
            var data1 = ItemsToDictionary(items1);

            names.AddRange(data1.Keys);
            foreach (var name in names.Distinct())
            {
                ret.Add(new SingleItem(data1[name]));
            }

            return ret;
        }

        Dictionary<string, Item> ItemsToDictionary(IEnumerable<Item> items)
        {
            Dictionary<string, Item> ret = new Dictionary<string, Item>();
            foreach (var item in items)
            {
                string key = item.getProperty("name", "");
                if (!ret.ContainsKey(key))
                {
                    ret.Add(key, item);
                }
            }

            return ret;
        }
    }
}
