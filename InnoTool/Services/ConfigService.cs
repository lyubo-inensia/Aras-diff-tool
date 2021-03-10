using InnoTool.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace InnoTool.Services
{
    public class ConfigService
    {
        public IEnumerable<ConnectionSettings> GetConnections()
        {
            return GetSettings().Connections;
        }

        protected string SettingsFilePath { get {
                var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "InnotTool");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                return Path.Combine(path, "settings.json");

            } }
        protected string DefaultSettingsFile { get; } = "settings.template.json";

        public bool SaveConnections(IEnumerable<ConnectionSettings> connections)
        {
            var ret = false;
            try
            {
                var settings = GetSettings();
                settings.Connections = connections;
                ret = SaveSettings(settings);
            }
            catch (Exception ex)
            {
            }

            return ret;
        }

        public bool SaveSettings(Settings settings)
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
                ret = true;
            }
            catch (Exception ex)
            {
            }

            return ret;
        }

        public bool SaveConnection(ConnectionSettings conn)
        {
            DeleteConnection(conn.Name);
            var conns = GetConnections().ToList();
            conns.Add(conn);

            return SaveConnections(conns);
        }

        public bool DeleteConnection(string name)
        {
            var conns = GetConnections().ToList();
            var c = conns.FirstOrDefault(e => e.Name == name);
            if (c != null) {
                conns.Remove(c);
            }
            SaveConnections(conns);

            return true;
        }

        public Settings GetSettings()
        {
            Settings ret = new Settings();
            try
            {
                if (!File.Exists(SettingsFilePath))
                {
                    File.Copy(DefaultSettingsFile, SettingsFilePath);
                }
                ret = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(SettingsFilePath));
                var sorted = ret.ItemTypes.ToList().OrderBy(str => str.ToString(), StringComparer.CurrentCultureIgnoreCase).ToList();
                ret.ItemTypes = sorted;
            }
            catch (Exception ex)
            {
                
            }

            return ret;
        }
    }
}
