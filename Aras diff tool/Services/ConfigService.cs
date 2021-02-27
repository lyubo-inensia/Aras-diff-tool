using ArasDiffTool.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ArasDiffTool.Services
{
    public class ConfigService
    {
        public IEnumerable<ConnectionSettings> GetConnections()
        {
            return GetSettings().Connections;
        }

        protected string Filename { get; } = "settings.json";

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
                    File.Delete(Filename);
                }
                catch (Exception)
                {
                }
                File.WriteAllText(Filename, json);
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

                ret = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(Filename));
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
