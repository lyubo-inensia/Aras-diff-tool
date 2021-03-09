using Aras.IOM;
using System;

namespace ArasDiffTool.Models
{
    public class SingleItem : BaseGridItem
    {

        public SingleItem(Item item)
        {
            DateTime mod = default;
            DateTime created = default;
            
            DateTime.TryParse(item.getProperty("modified_on"), out mod);
            DateTime.TryParse(item.getProperty("created_on"), out created);

            Id = item.getID();
            Type = item?.getType() ?? "";
            Name = item?.getProperty(GetNameProperty(item), "") ?? "";
            ModifiedDate = mod;
            CreatedDate = created;

        }
        public DateTime ModifiedDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
