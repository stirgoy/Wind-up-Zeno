﻿using System.Collections.Generic;
using System.Collections.Specialized;

namespace Wind_up_Zeno
{
    public partial class Zeno
    {
        public class ConfigZeno
        {

            public bool XIV_LN_enabled { get; set; } = true;
            public bool BadWordsBlackList { get; set; } = true;
            public bool ZenoLog { get; set; } = true; //why disable?
            public bool ConsoleLog { get; set; } = true; //same
            public bool RunBot { get; set; } = true;
            public bool AutoStart { get; set; } = false; //app behabior
            public bool UpdateSlashCommands { get; set; } = true;
            public int MaxReconnections { get; set; } = 1; //outdated
            public string Playing { get; set; } = "";
            public NewsIds Ids { get; set; }
            public KuruCFG Channels { get; set; }
            public StringCollection CacpotIds { get; set; } = new StringCollection() { };
            public string LastCacpot { get; set; } = "";
            public List<string[]> Events_Noticed { get; set; } = new List<string[]>(); //will save event = 0 users = rest
            public int[] FF_Schedules { get; set; } = new int[4] { 7, 15, 19, 19 };
            public int CacpotLoopDelay { get; set; } = 5000;

        }




        public class NewsIds
        {
            public string Update_last_id { get; set; } = "0";
            public string Status_last_id { get; set; } = "0";
            public string Topics_last_id { get; set; } = "0";
            public string Maintenance_last_id { get; set; } = "0";
            public string Notices_last_id { get; set; } = "0";
            public string Maintenance_last_companion_id { get; set; } = "0";
            public string Maintenance_last_game_id { get; set; } = "0";
            public string Maintenance_last_lodestone_id { get; set; } = "0";
            public string Maintenance_last_mog_id { get; set; } = "0";

        }

        public class KuruCFG
        {
            public StringCollection TalkChannel { get; set; } = new StringCollection() { };
            public ulong LogChannel { get; set; } = 0;
            public ulong Topics_channel { get; set; } = 0;
            public ulong Notices_channel { get; set; } = 0;
            public ulong Status_channel { get; set; } = 0;
            public ulong Update_channel { get; set; } = 0;
            public ulong Maintenance_channel { get; set; } = 0;
            public ulong All_news
            {
                set
                {
                    Topics_channel = value;
                    Notices_channel = value;
                    Status_channel = value;
                    Update_channel = value;
                    Maintenance_channel = value;
                }
            }
        }
    }
}
