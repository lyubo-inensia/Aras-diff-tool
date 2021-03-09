using Aras.IOM;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArasDiffTool.Models
{
    public class PackageDefinition
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }

        //public IEnumerable<PackageItem> Items { get; set; } = new List<PackageItem>();
    }
}
