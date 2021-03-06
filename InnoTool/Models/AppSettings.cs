﻿using InnoTool.Models;
using System;
using System.Collections.Generic;

namespace InnoTool.Models
{
    public class AppSettings
    {
        public AppSettings()
        {
            Connections = new List<ConnectionSettings>();
            ItemTypes = new List<ItemTypeSetting>();
        }
        public IEnumerable<ConnectionSettings> Connections { get; set; }

        public IEnumerable<ItemTypeSetting> ItemTypes { get; set; }

        public string Conn1Selected { get; set; }
        public string Conn2Selected { get; set; }
    }
}
