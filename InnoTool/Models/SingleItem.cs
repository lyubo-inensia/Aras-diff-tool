using Aras.IOM;
using System;

namespace InnoTool.Models
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
            Type = item?.getProperty("type") ?? "";
            Name = item?.getProperty("name", "") ?? "";
            Package = item?.getProperty("package", "") ?? "";
            ModifiedDate = mod;
            CreatedDate = created;

        }
        public DateTime ModifiedDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
