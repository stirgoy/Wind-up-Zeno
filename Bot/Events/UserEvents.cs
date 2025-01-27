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
        private async Task Kuru_UserJoined(SocketGuildUser user)
        {

            await Log($"{user.GlobalName} join server");
            string zenolog = $"Display name: {user.DisplayName + NL}Discord name: {user.Username + NL}Global name: {user.GlobalName + NL}Server name: {user.Nickname}";
            await ZenoLog($"{Emote.Bot.Sproud} NEW MEMBER!! {Emote.Bot.Sproud}", zenolog, user.GetAvatarUrl());

            var sproud = Kuru.GetRole(Role_sproud);
            await user.AddRoleAsync(sproud);

            await ZenoLog($"{Emote.Bot.LFP}Auto-role{Emote.Bot.LFP}", $"{user.Mention} has been added to {sproud.Mention}", user.GetAvatarUrl());
            await Log($"{user.GlobalName} have new Role: {sproud.Name}");

#if DEBUG
            string rules = "https://discord.com/channels/1284428695309910016/1307843815830454352";
            string welcome = "https://discord.com/channels/1284428695309910016/";
#else
            string rules = "https://discord.com/channels/1181272231477780571/1181272232442478664";
            string welcome = "https://discord.com/channels/1181272231477780571/";
#endif

            welcome += Channel_hi;

            string t = $"Welcome to {Kuru.Name} discord server!!";
            string d = $"Hello {user.Mention}!! I'm {Bot_Zeno.CurrentUser.Mention} {Emote.Bot.Pepelove + NL}Its a pleasure have you with us, keep a look on {rules}.{NL}When you are done type **!hi** on {welcome} {Emote.Bot.Happytuff}";
            Embed embd = CreateEmbed(t, d);
            var channel = await user.CreateDMChannelAsync();
            await channel.SendMessageAsync("", embed: embd);

        }

        private async Task Kuru_UserLeft(SocketGuild server, SocketUser user)
        {
            string zenolog = $"{Emote.Bot.Disconnecting} Discord name: {user.Username + NL}Global name: {user.GlobalName + NL} {Emote.Bot.Disconnecting}";
            await Log($"{user.GlobalName} leave server.");
            await ZenoLog($"{Emote.Bot.Disconnecting} We lose a member..... {Emote.Bot.Disconnecting}", zenolog, user.GetAvatarUrl());

        }
    }
}
