using Discord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wind_up_Zeno
{
    public partial class Zeno
    {

        private static async Task Print(string message, LogSeverity severity)
        {
            if (string.IsNullOrEmpty(message)) { return; }
            LogMessage lm = new LogMessage(severity, "Zeno", message);
            await Core.Bot.LogAsync(lm);
        }

        public static async Task Log(string message)
        {
            await Print(message, LogSeverity.Info);
        }

        public static async Task LogDebug(string message)
        {
            await Print(message, LogSeverity.Debug);
        }

        public static async Task LogError(string message)
        {
            await Print(message, LogSeverity.Error);
        }

        public async Task LogForm(string message)
        {
            await Print(message, LogSeverity.Info);
        }
    }
}
