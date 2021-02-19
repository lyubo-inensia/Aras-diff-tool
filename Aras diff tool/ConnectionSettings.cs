using System;

namespace ArasDiffTool
{
    public class ConnectionSettings
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string Database { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
