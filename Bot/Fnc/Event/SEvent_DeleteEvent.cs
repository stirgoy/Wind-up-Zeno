using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Wind_up_Zeno.XIVLN;

namespace Wind_up_Zeno
{
    public partial class Zeno
    {
        /********************
                Delete_Event
        *////////////////////
        private async Task SEvent_DeleteEvent(SocketGuildEvent server_event)
        {
            await Log("Event deletd from config");

            foreach (var item in Config.Events_Noticed)
            {
                if (item[0] == server_event.Id.ToString())
                {
                    Config.Events_Noticed.Remove(item);
                    await Config_Save();
                    break;
                }
            }
        }
    }
}
