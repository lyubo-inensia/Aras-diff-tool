using InnoTool.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace InnoTool.Services
{
    public class ConfigService : IConfigService
    {
        protected string SettingsFilePath
        {
            get
            {
                var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "InnotTool");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                return Path.Combine(path, "settings.json");

            }
        }
        protected string DefaultSettingsFile { get; } = "settings.template.json";
        protected AppSettings _settings;

        public bool SaveSettings(AppSettings settings)
        {
            var ret = false;
            try
            {
                var json = JsonConvert.SerializeObject(settings);
                try
                {
                    File.Delete(SettingsFilePath);
                }
                catch (Exception)
                {
                }
                File.WriteAllText(SettingsFilePath, json);
                _settings = settings;
                ret = true;
            }
            catch (Exception ex)
            {
            }

            return ret;
        }
        public AppSettings Reload()
        {
            _settings = null;

            return Settings;
        }
        public AppSettings Settings
        {
            get
            {
                if (_settings == null)
                {
                    try
                    {
                        if (!File.Exists(SettingsFilePath))
                        {
                            File.Copy(DefaultSettingsFile, SettingsFilePath);
                        }
                        _settings = JsonConvert.DeserializeObject<AppSettings>(File.ReadAllText(SettingsFilePath));
                        var sorted = _settings.ItemTypes.ToList().OrderBy(str => str.ToString(), StringComparer.CurrentCultureIgnoreCase).ToList();
                        _settings.ItemTypes = sorted;
                    }
                    catch (Exception ex)
                    {

                    }
                }

                return _settings;
            }
        }
    }
}
