using Discord;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Wind_up_Zeno
{
    public partial class Zeno
    {
        /********************
            SendGuide
        *//////////////////// 
        async void SendGuide(IDMChannel dm, int guide)
        {
            List<string> selguide = null;

            switch (guide)
            {
                case 0:
                    selguide = ClassRoom.Macros.Menu;
                    break;
                case 1:
                    selguide = ClassRoom.Macros.UsefulMacros;
                    break;
                case 2:
                    selguide = ClassRoom.Macros.HUD;
                    break;
                case 3:
                    selguide = ClassRoom.Macros.RetainerBasics;
                    break;
                default:
                    break;
            }



            foreach (var item in selguide)
            {
                await dm.SendMessageAsync(item);
                await Task.Delay(1000);
            }
        }


        /********************
            AnswerUser
        *//////////////////// 
        async void SimulateTyping(SocketUserMessage msg, string content)
        {
#if !DEBUG
            await msg.Channel.TriggerTypingAsync();
            await Task.Delay(3000);
#endif
            await msg.ReplyAsync(content);
        }

        /********************
            RegExFind
        *//////////////////// 
        bool RegExFind(string[] constant, string[] variable, string text)
        {
            string constantchain = string.Join("|", constant); // Une las palabras fijas con "|"
            string variablechain = string.Join("|", variable); // Une las palabras opcionales con "|"
            string patron = $@"\b({constantchain})\b.*\b({variablechain})\b|\b({variablechain})\b.*\b({constantchain})\b";
            Regex regex = new Regex(patron, RegexOptions.IgnoreCase);
            return regex.IsMatch(text);
        }
    }
}
