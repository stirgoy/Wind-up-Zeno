﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wind_up_Zeno
{
    public partial class Zeno
    {
        private async static Task Config_Load()
        {

            if (!Directory.Exists(Path)) { Directory.CreateDirectory(Path); }
            if (!File.Exists($"{Path}\\{Json_file}"))
            {
#if DEBUG
                Config.Channels.All_news = 1310199196233760858;
                Config.Channels.LogChannel = 1310199196233760858;
                Config.Channels.TalkChannel = new StringCollection() { "1310199196233760858", "1309843090202165258" };
#else
                Config.Channels.All_news = 1205502111979151420;
                Config.Channels.LogChannel = 1181272233260368010;
                Config.Channels.TalkChannel = new StringCollection() { "1181272233260368010", "1205502111979151420" };
#endif
                await GetLastNewsIds();
                await Config_Save();
                await Log("New default configuration file was created.");
            }

            string js = File.ReadAllText($"{Path}\\{Json_file}");
            ConfigZeno loaded = JsonConvert.DeserializeObject<ConfigZeno>(js);
            if (loaded != null)
            {
                Config = loaded;
            }

        }
    }
}
