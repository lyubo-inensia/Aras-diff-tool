using Aras.IOM;
using System;

namespace ArasDiffTool.Models
{
    public enum ItemChangeType
    {
        Created = 1,
        Modified = 2,
        Deleted = 3
    }
    public class DiffItem : BaseGridItem
    {

        public DiffItem(Item item1, Item item2)
        {
            DateTime mod1 = default;
            DateTime mod2 = default;
            DateTime created1 = default;
            DateTime created2 = default;
            if (item1 != null)
            {
                DateTime.TryParse(item1.getProperty("modified_on"), out mod1);
                DateTime.TryParse(item1.getProperty("created_on"), out created1);
            }
            if (item2 != null)
            {
                DateTime.TryParse(item2.getProperty("modified_on"), out mod2);
                DateTime.TryParse(item2.getProperty("created_on"), out created2);
            }
            Id = item1?.getID() ?? "";
            Type = (item1?.getType() ?? item2?.getType()) ?? "";
            Name = (item1?.getProperty(GetNameProperty(item1), "") ?? item2?.getProperty(GetNameProperty(item2), "")) ?? "";
            ModifiedDate1 = mod1;
            CreatedDate1 = created1;
            ModifiedDate2 = mod2;
            CreatedDate2 = created2;
        }
        public DateTime ModifiedDate1 { get; set; }
        public DateTime CreatedDate1 { get; set; }
        public DateTime ModifiedDate2 { get; set; }
        public DateTime CreatedDate2 { get; set; }
        public ItemChangeType ChangeType { get; set; }
    }
}
