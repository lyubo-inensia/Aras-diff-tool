using Aras.IOM;
using System;
using System.Collections.Generic;
using System.Text;

namespace InnoTool.Models
{
    public abstract class BaseGridItem : IBaseItem
    {
        public string Id { get; set; }
        public string ParentId { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Package { get; set; }
        public IEnumerable<IBaseItem> Dependencies { get; set; } = new List<IBaseItem>();
    }
}
