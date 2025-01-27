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
        public Action<string> OnLog;

        internal Task LogAsync(LogMessage log)
        {
            string logEntry;

            //lets try don't miss logs
            if (log.Message != null)
            {
                logEntry = $"[{log.Severity}] {log.Source}: {log.Message}";
            }
            else if (log.Exception != null)
            {
                logEntry = $"[{log.Severity}] {log.Source}: {log.Exception.Message} | {log.Exception.GetType()}";
            }
            else
            {
                logEntry = $"{ParseMsg(log)}";
            }

            OnLog?.Invoke(logEntry);
            return Task.CompletedTask;
        }


        private static string ParseMsg(LogMessage log)
        {
            string r = $"[{log.Severity}] {log.Source}: ";

            
            string msg = log.ToString() ;
            msg = msg.Replace(r, "");


            return r + msg;
        }

    }
}
