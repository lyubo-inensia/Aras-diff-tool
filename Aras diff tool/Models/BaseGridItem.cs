using Aras.IOM;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArasDiffTool.Models
{
    public abstract class BaseGridItem : IBaseItem
    {
        public const string NameProperty = "diff_name_prop";
        public string Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }

        protected string GetNameProperty(Item item)
        {
            var ret = item?.getProperty(NameProperty) ?? "name";

            return ret;
        }
    }
}
