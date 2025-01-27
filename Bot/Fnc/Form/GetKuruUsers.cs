using Discord;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Wind_up_Zeno
{
    public partial class Zeno
    {
        public List<SocketGuildUser> GetKuruUsers()
        {
            Kuru.DownloadUsersAsync();
            List<SocketGuildUser> list = new List<SocketGuildUser>();
            foreach (var item in Bot_Zeno.Guilds.First().Users)
            {
                list.Add(item);
            }
            return list;
        }

    }
}
