using System.Collections.Generic;

namespace InnoTool.Models
{
    public interface IBaseItem
    {
        string Id { get; set; }
        string ParentId { get; set; }
        string Name { get; set; }
        string Type { get; set; }
        string Package { get; set; }
        IEnumerable<IBaseItem> Dependencies { get; set; }
    }
}