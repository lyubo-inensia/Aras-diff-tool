using InnoTool.Models;

namespace InnoTool.Services
{
    public interface IConfigService
    {
        AppSettings Settings { get; }

        AppSettings Reload();
        bool SaveSettings(AppSettings settings);
    }
}