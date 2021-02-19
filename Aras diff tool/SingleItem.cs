using Aras.IOM;
using System;

namespace ArasDiffTool
{
    public class SingleItem
    {

        public SingleItem(Item item)
        {
            DateTime mod = default;
            DateTime created = default;
            
            DateTime.TryParse(item.getProperty("modified_on"), out mod);
            DateTime.TryParse(item.getProperty("created_on"), out created);
            
            Type = item?.getType() ?? "";
            Name = item?.getProperty("name", "") ?? "";
            ModifiedDate = mod;
            CreatedDate = created;

        }
        public string Type { get; set; }
        public string Name { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
