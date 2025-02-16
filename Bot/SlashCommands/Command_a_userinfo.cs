﻿using Discord;
using Discord.WebSocket;
using System;
using System.Linq;
using System.Reactive;
using System.Threading.Tasks;

namespace Wind_up_Zeno
{
    public partial class Zeno
    {
        //              /userinfo
        private async Task Command_a_userinfo(SocketSlashCommand command)
        {
            var user_n = command.Data.Options.FirstOrDefault(opt => opt.Name == "name");
            if (user_n?.Value is IUser user_name) { } else { return; }

            await command.DeferAsync(ephemeral: true);

            SocketGuildUser sgu = Kuru.GetUser(user_name.Id);
            //              lulu                str
            //print(user_name.GlobalName + " " + user_name.Username);
            await Log($"{command.User.Username} => a_userinfo {user_n}");

            string roles = "Error getting roles. " + Emote.Bot.Boss;

            if (sgu != null)
            {
                roles = "";

                foreach (var item in sgu.Roles)
                {
                    if (item.Name == sgu.Roles.Last().Name)
                    {
                        roles += item + ".";
                    }
                    else
                    {
                        roles += item + ", ";
                    }
                }

            }
            else
            {
                await LogError("NULL USER");
            }

            var roleList = string.Join(", ", sgu.Roles.Where(x => !x.IsEveryone).Select(x => x.Mention));
            roleList.Remove(roleList.Length - 2);
            roleList += ".";

            string nik = sgu.Nickname;
            if (nik == null) { nik = "none"; }
            string avatarUrl = sgu.GetAvatarUrl(ImageFormat.Auto, 512);
            string kuruj = "No data";
            string kurus = "No data";

            if (sgu.JoinedAt is DateTimeOffset sguj)
            {
                long ks = sguj.ToUnixTimeSeconds();
                kuruj = $"<t:{ks}:f>";
            }

            if (sgu.CreatedAt is DateTimeOffset sgus)
            {
                long ks = sgus.ToUnixTimeSeconds();
                kurus = $"<t:{ks}:f>";
            }

            string admin = (sgu.GuildPermissions.Administrator) ? Emote.XD.GeenCircle : Emote.XD.RedCircle;

            var user_emb = new EmbedBuilder()
                .WithTitle($"User information")
                .AddField("Display name", $"{sgu.DisplayName}")
                .AddField("User name", $"{sgu.Username}")
                .AddField("Global name", $"{sgu.GlobalName}")
                .AddField("Server name", $"{nik}")
                .AddField($"Join to Kuru", kuruj)
                .AddField($"Join to Discord", kurus)
                .AddField("Is admin", admin)
                .AddField("Roles", $"{roleList}")
                .WithThumbnailUrl(avatarUrl)
                .WithFooter($" My enemy.")
                .WithColor(Color.Orange)
                .Build();
            /*
            var user_emb = new EmbedBuilder()
                .WithTitle($"User information")
                .AddField("Display name", $"{sgu.DisplayName}", true)
                .AddField("User name", $"{sgu.Username}", true)
                .AddField("Global name", $"{sgu.GlobalName}", true)
                .AddField("Server name", $"{nik}", true)
                .AddField($"Join to Kuru", kuruj, true)
                .AddField($"Join to Discord", kurus, true)
                .AddField("Is admin", admin, true)
                .AddField("Roles", $"{roleList}")
                .WithThumbnailUrl(avatarUrl)
                .WithFooter($" My enemy.")
                .WithColor(Color.Orange)
                .Build();*/

            var m = await command.FollowupAsync("", embed: user_emb, ephemeral: true);
            BorrarMsg(m, 60);
        }
    }
}
