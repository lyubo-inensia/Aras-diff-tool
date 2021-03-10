using System;
using System.Collections.Generic;
using System.Text;

namespace InnoTool.Models
{
    public class ItemTypeSetting
    {
        public const string DEFAULT_PROPERTY = "name";
        public string ItemType { get; set; }
        public string Property { get; set; }
        public bool Checked { get; set; } = false;

        public override string ToString()
        {
            return (ItemType ?? "") + ": " + (Property ?? DEFAULT_PROPERTY);
        }
    }
}
