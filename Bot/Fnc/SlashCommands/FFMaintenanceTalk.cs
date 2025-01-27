﻿using Discord;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Wind_up_Zeno
{
    public partial class Zeno
    {
        /********************
            FFMaintTalk
        *//////////////////// 
        async Task<Embed> FFMaintenanceTalk()
        {
            HttpClient client = new HttpClient();
            Embed embed = null;
            MaintenanceRoot data = null;
            string title = $"{Emote.Bot.LMaintenance} Current Maintenance";

            string jsonMaintenance = await client.GetStringAsync(XIVLN.APIs.MaintenanceCurrent);
            bool empty = true;

            if (!string.IsNullOrEmpty(jsonMaintenance))
            {
                data = JsonConvert.DeserializeObject<MaintenanceRoot>(jsonMaintenance);
                empty = (data == null || data.Game.Count == 0);
            }

            if (!empty)
            {
                foreach (var item in data.Game)
                {
                    string st = UnixTime(DateTime.Parse(item.Start));
                    string et = UnixTime(DateTime.Parse(item.End));
                    string tt = UnixTime(DateTime.Parse(item.Time));

                    embed = CreateEmbedField_2(
                        title,
                        "### [" + item.Title + $"](<{item.Url}>)" + NL + NL + $"-# {tt}",
                        $"Start time: {NL + UnixTime(DateTime.Parse(item.Start), "d") + NL + UnixTime(DateTime.Parse(item.Start), "t")}",
                        st,
                        $"End time: {NL + UnixTime(DateTime.Parse(item.End), "d") + NL + UnixTime(DateTime.Parse(item.End), "t")}",
                        et,
                        StringT.LN_from,
                        XIVLN.Config.FFLogo,
                        color: Color.Blue);
                }
            }
            else
            {
                embed = CreateEmbed(
                    "I got nothing... " + Emote.Bot.Disconnecting_party,
                    "Is game on maintenance??? " + Emote.Bot.Disconnecting_party,
                    color: Color.Red);
            }

            return embed;

        }
    }
}
