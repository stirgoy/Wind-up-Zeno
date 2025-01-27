﻿using Discord;
using Discord.WebSocket;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Wind_up_Zeno
{
    public partial class Zeno
    {
        /********************
          LodestoneHandler
        *////////////////////
        private async Task Command_ffhandler(SocketSlashCommand command, string kindOf)
        {
            try
            {
                //SOURCE https://documenter.getpostman.com/view/1779678/TzXzDHVk#5bd3a0a5-43b1-408d-bb7a-1788f22662a8

                await command.DeferAsync(ephemeral: false);

                //setting up
                var cantidadOption = command.Data.Options.FirstOrDefault(opt => opt.Name == "number");
                string apiUrl;
                string title;
                string jsonMaintenance;
                string jsonCommon;
                int def = 1;
                int min = 1;
                int max = 5;
                bool empty = true;
                List<Embed> ret = new List<Embed>();
                List<LodestoneNews> newsListD = new List<LodestoneNews>();
                MaintenanceRoot data = null;
                HttpClient client = new HttpClient();

                int cantidad = cantidadOption?.Value is long value ? (int)value : def;
                if (cantidad > max) { cantidad = max; }
                if (cantidad <= 0) { cantidad = min; }

                switch (kindOf)
                {
                    case "news":
                        apiUrl = XIVLN.APIs.Topics;
                        title = $"{Emote.Bot.LTopics} Tpoics";
                        break;

                    case "maintenance_c":
                        apiUrl = XIVLN.APIs.MaintenanceCurrent;
                        title = $"{Emote.Bot.LMaintenance} Current Maintenance";
                        break;

                    case "maintenance":
                        apiUrl = XIVLN.APIs.Maintenance;
                        title = $"{Emote.Bot.LMaintenance} Maintenance";
                        break;

                    case "updates":
                        apiUrl = XIVLN.APIs.Updates;
                        title = $"{Emote.Bot.LUpdate} Updates";
                        break;

                    case "status":
                        apiUrl = XIVLN.APIs.Status;
                        title = $"{Emote.Bot.LStatus} Status";
                        break;

                    case "notices":
                        apiUrl = XIVLN.APIs.Notices;
                        title = $"{Emote.Bot.Lnotices} Notices";
                        break;

                    default:
                        apiUrl = XIVLN.APIs.Topics;
                        title = $"{Emote.Bot.LTopics} Tpoics";
                        break;
                }

                //get news
                if (kindOf == "maintenance_c")
                {
                    jsonMaintenance = await client.GetStringAsync(apiUrl);
                    if (string.IsNullOrEmpty(jsonMaintenance))
                    {
                        await LogError("NEWS ARE EMPTY OR NULL");
                    }
                    else
                    {
                        data = JsonConvert.DeserializeObject<MaintenanceRoot>(jsonMaintenance);
                        empty = (data == null || data.Game.Count == 0);
                        cantidad = 1; //plz xD
                    }

                }
                else
                {
                    jsonCommon = await client.GetStringAsync(apiUrl);
                    if (string.IsNullOrEmpty(jsonCommon))
                    {
                        await LogError("NEWS ARE EMPTY OR NULL");
                    }
                    else
                    {
                        newsListD = JsonConvert.DeserializeObject<List<LodestoneNews>>(jsonCommon);
                        empty = (newsListD == null || newsListD.Count == 0);
                    }
                }


                //build
                if (empty)
                {
                    string tit = (kindOf == "maintenance_c") ? "I got nothing... " + Emote.Bot.Disconnecting_party : " Error " + Emote.Bot.Disconnecting_party;
                    string str = (kindOf == "maintenance_c") ? "Is game on maintenance??? " + Emote.Bot.Disconnecting_party : "No data recieved. " + Emote.Bot.Disconnecting_party;

                    await LogError("NEW LIST IS NULL");

                    var embed = CreateEmbed(
                        tit,
                        str,
                        color: Color.Red);

                    await command.FollowupAsync(embed: embed);
                }
                else
                {


                    if (kindOf == "maintenance_c")
                    {

                        foreach (var item in data.Game)
                        {
                            string st = UnixTime(DateTime.Parse(item.Start));
                            string et = UnixTime(DateTime.Parse(item.End));
                            string tt = UnixTime(DateTime.Parse(item.Time));

                            var embed = CreateEmbedField_2(
                                title,
                                "### [" + item.Title + $"](<{item.Url}>)" + NL + NL + $"-# {tt}",
                                $"Start time: {NL + UnixTime(DateTime.Parse(item.Start), "d") + NL + UnixTime(DateTime.Parse(item.Start), "t")}",
                                st,
                                $"End time: {NL + UnixTime(DateTime.Parse(item.End), "d") + NL + UnixTime(DateTime.Parse(item.End), "t")}",
                                et,
                                StringT.LN_from,
                                XIVLN.Config.FFLogo,
                                color: Color.Blue);

                            ret.Add(embed);
                        }
                    }
                    else
                    {
                        foreach (var item in newsListD.Take(cantidad))
                        {
                            string start_desc = $"### [{item.Title}]({item.Url})" + NL + NL;
                            string end_desc = NL + NL + "-# " + UnixTime(item.Time);
                            var embed = new EmbedBuilder()
                                .WithTitle(title)
                                .WithUrl(item.Url)
                                .WithImageUrl(item.Image)
                                .WithDescription(start_desc + item.Description + end_desc)
                                .WithColor(Color.Blue)
                                .WithThumbnailUrl(XIVLN.Config.FFLogo)
                                .WithFooter(StringT.LN_from)
                                .Build();

                            ret.Add(embed);
                        }

                    }

                    //send :D
                    await command.FollowupAsync("", embeds: ret.ToArray(), ephemeral: false);

                }
            }
            catch (Exception ex)
            {
                await LogError("Command_ffhandler error");
                await LogError(ex.Message);
                await LogError(ex.Source);
                if (ex.InnerException != null)
                {
                    await LogError(ex.InnerException.ToString());
                }
            }
        }
    }
}
