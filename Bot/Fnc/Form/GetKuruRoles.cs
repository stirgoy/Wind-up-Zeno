using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wind_up_Zeno
{
    public partial class Zeno
    {
        public List<SocketRole> GetKuruRoles()
        {
            Kuru.DownloadUsersAsync();
            List<SocketRole> list = new List<SocketRole>();
            foreach (var item in Bot_Zeno.Guilds.First().Roles)
            {
                list.Add(item);
            }
            return list;
        }
    }
}
