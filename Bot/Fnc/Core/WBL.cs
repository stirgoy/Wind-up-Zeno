using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Wind_up_Zeno
{
    public partial class Zeno
    {
        private async Task WBL(SocketMessage message)
        {
            if (!Config.BadWordsBlackList) return;
            var author = message.Author;
            if (author.IsBot) { return; }


            string msgcontent = message.Content.ToLower();

            foreach (string item in WBL_List)
            {
                Regex re = new Regex($@"\b{item}\b", RegexOptions.IgnoreCase);
                if (re.IsMatch(msgcontent))
                {
                    await message.DeleteAsync();

                    var serverChannel = Kuru.GetTextChannel(message.Channel.Id);

                    string log = $"Baned word detected. User: {message.Author.Username} typed: {item} on channel: {message.Channel.Name}";
                    string logz = $"Baned word detected. User: {message.Author.Mention} typed: `{item}` on channel: {serverChannel.Mention}";
                    string loguser = $"Ops you type the banned word: `{item}` so i deleted you message on: {serverChannel.Mention} D:";
                    await AddWarn(message.Author.Id, 1);
                    await Log(log);
                    await ZenoLog(logz);
                    var userdm = await message.Author.CreateDMChannelAsync();
                    await userdm.SendMessageAsync(loguser);

                    break; //one is enough
                }
            }

        }

        private static async Task WBL_Load()
        {
            if (!Directory.Exists(Path)) { Directory.CreateDirectory(Path); }
            string fullpath = $"{Path}\\{Words_file}";

            if (!File.Exists(fullpath))
            {
                var f = File.Create(fullpath);
                f.Close();

                await Log("New default word black list file was created.");
            }
            else
            {
                WBL_List = File.ReadAllLines(fullpath).ToList();

                foreach (string item in WBL_List)
                {
                    if (item == "" || item == " ") { WBL_List.Remove(item); }
                }
            }
            
        }

        private List<string[]> WarnListParse()
        {
            string fullpath = System.IO.Path.Combine(Path, Warns_file);
            List<string[]> warnList = new List<string[]>();

            if (!Directory.Exists(Path)) Directory.CreateDirectory(Path);
            if (!File.Exists(fullpath))
            {
                var f = File.Create(fullpath);
                f.Close();
            }
            else
            {
                var warnings = File.ReadAllLines(fullpath).ToList();

                foreach (var item in warnings)
                {
                    warnList.Add(item.Split(','));
                }
                return warnList;
            }

            return warnList; // no results

        }


        private List<string> WarnListParse(List<string[]> WarnList)
        {
            List<string> warnList = new List<string>();

            foreach (var item in WarnList)
            {
                warnList.Add(string.Join(",", item));
            }

            return warnList;
        }
    }
}
