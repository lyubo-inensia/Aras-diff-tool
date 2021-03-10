using Aras.IOM;
using InnoTool.Models;
using InnoTool.Services;

namespace InnoTool.Factories
{
    public interface IMainFactory
    {
        IConfigService GetConfigService();
        IDiffService GetDiffService();
        Innovator GetInnovator(ConnectionSettings conn);
        InnovatorService GetInnovatorService(ConnectionSettings conn);
        IPackageService GetPackageService(ConnectionSettings conn);
    }
}