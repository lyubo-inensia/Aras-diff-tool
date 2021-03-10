using InnoTool.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InnoTool.Services
{
    public interface IPackageService
    {
        InnovatorService Inn { get; }

        IEnumerable<IBaseItem> AddItemsToPackage(string packId, IEnumerable<IBaseItem> items, string packageName, bool moveItems = false);
        PackageDefinition AddPackage(string name);
        Task<IEnumerable<PackageDefinition>> GetPackages();
    }
}