using System;
using System.Collections.Generic;

namespace ArasDiffTool
{
    public class Settings
    {
        public Settings()
        {
            Connections = new List<ConnectionSettings>();
            ItemTypes = new List<string>();
        }
        public IEnumerable<ConnectionSettings> Connections { get; set; }

        public IEnumerable<string> ItemTypes { get; set; }

        public string Conn1Selected { get; set; }
        public string Conn2Selected { get; set; }
    }
}
