using Discord;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Wind_up_Zeno
{

    public partial class Zeno
    {
        //core
        public static DiscordSocketClient Bot_Zeno { get; set; }
        internal static SocketGuild Kuru { get; set; } = null;
        private static string NL { get => Environment.NewLine; }

        private static readonly DiscordSocketConfig CordSocketConfig = new DiscordSocketConfig
        {
            GatewayIntents = (
                GatewayIntents.Guilds |
                GatewayIntents.GuildMembers |
                GatewayIntents.MessageContent |
                GatewayIntents.AllUnprivileged |
                GatewayIntents.GuildScheduledEvents
                ) & ~GatewayIntents.GuildInvites
        };

        //Config Settings
        public static string Path { get => Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Zeno"; }
        public static string Json_file { get => "kuru.json"; }
        public static string Words_file { get => "wbl.txt"; }
        public static string Warns_file { get => "warns.txt"; }

        //word blacklist
        private static List<string> WBL_List = new List<string>();

        //persistent config
        public static ConfigZeno Config = new ConfigZeno()
        {
            Ids = new NewsIds(),
            Channels = new KuruCFG()
        };

#if DEBUG
        //autorole
        private readonly ulong Role_sproud = 1326212765928656977;
        private readonly ulong Role_normal = 1285702794078191616;
        private readonly ulong Channel_hi = 1326510690982170646;        //welcome
        private readonly ulong Channel_greetings = 1310199196233760858; //test bot 
        private readonly ulong Channel_zenos = 1310199196233760858;

#else
        //autorole
        private readonly ulong Channel_zenos = 1315324417475219518;
        private readonly ulong Role_sproud = 1181272231477780576;
        private readonly ulong Role_normal = 1181272231477780577;
        //private readonly ulong Channel_hi = 1181272232442478665; //welcome
        private readonly ulong Channel_hi = 1181272232442478664; //rules
        private readonly ulong Channel_greetings = 1181272233260368004; // General chat

#endif

    }


}
