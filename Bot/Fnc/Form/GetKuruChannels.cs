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
        public List<SocketTextChannel> GetKuruChannels()
        {          
            
            List<SocketTextChannel> list = new List<SocketTextChannel>();
            foreach (var item in Bot_Zeno.Guilds.First().Channels)
            {
                if (item is SocketTextChannel channel)
                {
                    list.Add(channel);
                }
            }
            return list;
        }
    }
}
