using Discord.WebSocket;
using System.Collections.Generic;

namespace Wind_up_Zeno
{
    internal static class Core
    {
        internal static Zeno Bot;
        internal static Dictionary<string, string> Emotes = new Dictionary<string, string>();
        internal static bool ExtraLog = false;
        //TODO load new config
    }
}
