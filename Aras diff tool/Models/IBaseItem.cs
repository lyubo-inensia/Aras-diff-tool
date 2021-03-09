namespace ArasDiffTool.Models
{
    public interface IBaseItem
    {
        string Id { get; set; }
        string Name { get; set; }
        string Type { get; set; }
    }
}