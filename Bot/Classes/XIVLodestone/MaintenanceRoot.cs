﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wind_up_Zeno
{
    public class MaintenanceRoot
    {
        public List<MaintenanceEvent> Companion { get; set; }
        public List<MaintenanceEvent> Game { get; set; }
        public List<MaintenanceEvent> Lodestone { get; set; }
        public List<MaintenanceEvent> Mog { get; set; }
        public List<object> Psn { get; set; }
    }

    public class MaintenanceEvent
    {
        public string Id { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public string Time { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public bool Current { get; set; }
    }
}
