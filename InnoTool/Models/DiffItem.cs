﻿using Aras.IOM;
using System;

namespace InnoTool.Models
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
            ParentId = item1?.getProperty("parent_id") ?? "";
            Type = (item1?.getProperty("type") ?? item2?.getProperty("type")) ?? "";
            Name = (item1?.getProperty("name", "") ?? item2?.getProperty("name", "")) ?? "";
            Package = item1?.getProperty("package", "") ?? "";
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
