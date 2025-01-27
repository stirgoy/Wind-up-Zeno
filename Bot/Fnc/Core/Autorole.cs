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
        /********************
            Autorole
        *//////////////////// 
        private async void Autorole(SocketGuildUser serveruser, SocketMessage message)
        {
            var userMessage = message as SocketUserMessage;
            var sproud = Kuru.GetRole(Role_sproud);
            var normal = Kuru.GetRole(Role_normal);

            if (serveruser.Roles.Contains(sproud))
            {
                BorrarMsg(userMessage, 0);

                await serveruser.AddRoleAsync(normal);
                await ZenoLog($"{Emote.Bot.LFP}Auto-role{Emote.Bot.LFP}", $"{serveruser.Mention} has been added to {normal.Mention}", serveruser.GetAvatarUrl());
                await Log($"{serveruser.Mention} has been added to {normal.Mention}");

                await serveruser.RemoveRoleAsync(sproud);
                await ZenoLog($"{Emote.Bot.LFP}Auto-role{Emote.Bot.LFP}", $"{serveruser.Mention} has been removed to {sproud.Mention}", serveruser.GetAvatarUrl());
                await Log($"{serveruser.Mention} has been removed to {sproud.Mention}");

                var greetingschannel = Kuru.GetTextChannel(Channel_greetings);
                await greetingschannel.SendMessageAsync($"{Emote.Bot.Pepeshookt} Welcome {userMessage.Author.Mention + " " + Emote.Bot.Happytuff} you and me will be best friends {Emote.Bot.Pepelove} and enemies {Emote.Bot.Boss}!!!");


                await Log($"{serveruser.GlobalName} has registered  on server!!");

            }
            else
            {
                await Log($"{message.Author.GlobalName} is trying to verify again...");

            }
        }
    }
}
