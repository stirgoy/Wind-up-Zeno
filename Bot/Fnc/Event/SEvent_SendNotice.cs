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
        /********************
               SendEventNotice
       *////////////////////
        private async void SEvent_SendNotice(string uid, SocketGuildEvent server_event)
        {
            //await Kuru.DownloadUsersAsync();
            var user = Kuru.GetUser(ulong.Parse(uid));
            IDMChannel dm = await user.CreateDMChannelAsync();
            Embed emb = CreateEmbed($"Hey! {user.DisplayName} Wake up!!", $"{Emote.Bot.Online} The event: **{server_event.Name}**{NL}Just start now!!!! {Emote.Bot.Online}", miniImage: Kuru.IconUrl);
            await dm.SendMessageAsync("", embed: emb);

        }
    }
}
