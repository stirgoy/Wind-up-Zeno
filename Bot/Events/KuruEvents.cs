using Discord.Rest;
using Discord.WebSocket;
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

        private async Task SEvent_UserAdd(Cacheable<SocketUser, RestUser, IUser, ulong> user, SocketGuildEvent server_event)
        {
            await Log($"New user added {user.Id} on event {server_event.Id}");

            string[] event_data = SEvent_GetEvent(server_event.Id.ToString());
            List<string[]> evnts = Config.Events_Noticed;

            if (!event_data.Contains(user.Id.ToString()))
            {
                for (int i = 0; i < evnts.Count; i++)
                {
                    if (evnts[i][0] == server_event.Id.ToString())
                    {
                        List<string> newlist = evnts[i].ToList();
                        newlist.Add(user.Id.ToString());
                        evnts[i] = newlist.ToArray();
                        Config.Events_Noticed = evnts;
                        await Config_Save();
                        break;
                    }
                }
            }

        }


        private async Task SEvent_UserRemove(Cacheable<SocketUser, RestUser, IUser, ulong> user, SocketGuildEvent server_event)
        {
            await Log($"New user removed {user.Id} on event {server_event.Id}");

            List<string[]> evnts = Config.Events_Noticed;

            for (int i = 0; i < evnts.Count; i++)
            {
                if (evnts[i][0] == server_event.Id.ToString())
                {
                    List<string> newlist = evnts[i].ToList();
                    if (newlist.Contains(user.Id.ToString()))
                    {
                        newlist.Remove(user.Id.ToString());
                        evnts[i] = newlist.ToArray();
                        Config.Events_Noticed = evnts;
                        await Config_Save();
                        break;
                    }
                }
            }
        }

        private async Task SEvent_Canceled(SocketGuildEvent server_event)
        {
            await Log("Event canceled");
            await SEvent_DeleteEvent(server_event);

        }

        private async Task SEvent_Completed(SocketGuildEvent server_event)
        {

            await Log("Event completed");
            await SEvent_DeleteEvent(server_event);
        }

        private async Task SEvent_Created(SocketGuildEvent server_event)
        {
            await Log("New event added on server");

            string[] newEvent = new string[] { server_event.Id.ToString() };
            Config.Events_Noticed.Add(newEvent);
            await Config_Save();

        }

        private async Task SEvent_Started(SocketGuildEvent server_event)
        {
            await Log("Event started");

            var data = SEvent_GetEvent(server_event.Id.ToString());

            foreach (string item in data)
            {
                if (item != data.First()) //need skip 1st because its event id
                {
                    SEvent_SendNotice(item, server_event);
                    await Task.Delay(100);
                }
            }
        }

        





    }
}
