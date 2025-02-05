using Discord.WebSocket;
using Discord;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Wind_up_Zeno
{
    public partial class Zeno
    {
        static Timer XIV_Timer;

        public static void XIV_LN()
        {
            if (Config.XIV_LN_enabled)
            {
                XIV_Timer = new Timer(XIV_LN_Loop, null, 10, XIVLN.Config.TimerInterval); //timer
            }
        }

        public void StopXIVLN()
        {
            XIV_Timer.Change(Timeout.Infinite, Timeout.Infinite);            
            XIV_Timer.Dispose();
        }

        static async void XIV_LN_Loop(object state)
        {
            try
            {
                Lnisstop = false;
                XIV_Timer.Change(Timeout.Infinite, Timeout.Infinite); //stop timer

                HttpClient H_Client = new HttpClient();

                await LogExtra("XIVLN calling API...");
                //lets call api each 2 sec
                string jsonTopics = await H_Client.GetStringAsync(XIVLN.APIs.Topics);
                await Task.Delay(XIVLN.Config.APIDelay);
                string jsonStatus = await H_Client.GetStringAsync(XIVLN.APIs.Status);
                await Task.Delay(XIVLN.Config.APIDelay);
                string jsonUpdates = await H_Client.GetStringAsync(XIVLN.APIs.Updates);
                await Task.Delay(XIVLN.Config.APIDelay);
                string json_Notices = await H_Client.GetStringAsync(XIVLN.APIs.Notices);
                await Task.Delay(XIVLN.Config.APIDelay);
                string jsonMaintenance = await H_Client.GetStringAsync(XIVLN.APIs.Maintenance);
                await Task.Delay(XIVLN.Config.APIDelay);
                string jsonMaintenance_Current = await H_Client.GetStringAsync(XIVLN.APIs.MaintenanceCurrent);
                await LogExtra("XIVLN data recieved.");

                bool have_Topics = !(string.IsNullOrEmpty(jsonTopics));
                bool have_Status = !(string.IsNullOrEmpty(jsonStatus));
                bool have_Updates = !(string.IsNullOrEmpty(jsonUpdates));
                bool have_Notices = !(string.IsNullOrEmpty(json_Notices));
                bool have_Maintenance = !(string.IsNullOrEmpty(jsonMaintenance));
                bool have_Maintenance_Current = !(string.IsNullOrEmpty(jsonMaintenance_Current));

                //lnisstop = false;
                if (Bot_Zeno.ConnectionState != ConnectionState.Connected) { Lnisstop = true;  await Log("XIVLN stoped."); return; }
                //  --Topics--
                if (have_Topics)
                {
                    List<LodestoneNews> List_Topics = JsonConvert.DeserializeObject<List<LodestoneNews>>(jsonTopics);

                    if (Config.Ids.Topics_last_id == "0")
                    {
                        Config.Ids.Topics_last_id = List_Topics[XIVLN.Config.MaxNewsOnFirst].Id;
                        await Config_Save();
                    }

                    if (Config.Ids.Topics_last_id != List_Topics.First().Id)
                    {

                        int howMany = 0;

                        foreach (LodestoneNews item in List_Topics)
                        {
                            if (item.Id == Config.Ids.Topics_last_id) { break; } else { howMany++; }
                        }

                        SocketTextChannel _channel = Kuru.GetTextChannel(Config.Channels.Topics_channel);

                        for (int i = 0; i < howMany; i++)
                        {

                            string end_desc = NL + NL + "-# ";
                            end_desc += UnixTime(List_Topics[i].Time);
                            string start_desc = $"### [{List_Topics[i].Title}]({List_Topics[i].Url})" + NL + NL;

                            Embed embed = new EmbedBuilder()
                                            .WithTitle($"{Emote.Bot.LTopics} Tpoics")
                                            .WithImageUrl(List_Topics[i].Image)
                                            .WithDescription(start_desc + List_Topics[i].Description + end_desc)
                                            .WithThumbnailUrl(XIVLN.Config.FFLogo)
                                            .WithColor(Color.Blue)
                                            .WithFooter(StringT.LN_from)
                                            .Build();
                            if (_channel != null)
                            {
                                await _channel.SendMessageAsync("", embed: embed);
                                await Log($"XIVLodestoneNews => new topic post: {List_Topics[i].Id}");
                            }
                            else
                            {
                                await ZenoLog($"Error trying send FFXIV_LN_Topic: {List_Topics[i].Id}. Channel is null {Emote.Bot.Sadtuff}");
                                await Log($"LodestoneNews: No channel on topics!!!");
                            }
                        }

                        Config.Ids.Topics_last_id = List_Topics[0].Id;
                        await Config_Save();

                    }

                }


                if (Bot_Zeno.ConnectionState != ConnectionState.Connected) { Lnisstop = true; await Log("XIVLN stoped."); return; }
                //  --Status--
                if (have_Status)
                {
                    List<LodestoneNews> List_Status = JsonConvert.DeserializeObject<List<LodestoneNews>>(jsonStatus);

                    if (Config.Ids.Status_last_id == "0")
                    {
                        Config.Ids.Status_last_id = List_Status[XIVLN.Config.MaxNewsOnFirst].Id;
                        await Config_Save();
                    }
                    if (Config.Ids.Status_last_id != List_Status.First().Id)
                    {

                        int howMany = 0;

                        foreach (LodestoneNews item in List_Status)
                        {
                            if (item.Id == Config.Ids.Status_last_id) { break; } else { howMany++; }
                        }

                        SocketTextChannel _channel = Kuru.GetTextChannel(Config.Channels.Status_channel);

                        for (int i = 0; i < howMany; i++)
                        {
                            string end_desc = NL + NL + "-# ";
                            string start_desc = $"### [{List_Status[i].Title}]({List_Status[i].Url})" + NL + NL;
                            end_desc += UnixTime(List_Status[i].Time);

                            Embed embed = new EmbedBuilder()
                                            .WithTitle($"{Emote.Bot.LStatus} Status")
                                            .WithDescription(start_desc + List_Status[i].Description + end_desc)
                                            .WithThumbnailUrl(XIVLN.Config.FFLogo)
                                            .WithColor(Color.Blue)
                                            .WithFooter(StringT.LN_from)
                            .Build();

                            if (_channel != null)
                            {
                                await _channel.SendMessageAsync("", embed: embed);
                                await Log($"XIVLodestoneNews => new status post: {List_Status[i].Id}");
                            }
                            else
                            {
                                await ZenoLog($"Error trying send FFXIV_LN_Status: {List_Status[i].Id}. Channel is null {Emote.Bot.Sadtuff}");
                                await Log($"LodestoneNews: No channel on status!!!");
                            }
                        }

                        Config.Ids.Status_last_id = List_Status[0].Id;
                        await Config_Save();
                    }
                }

                if (Bot_Zeno.ConnectionState != ConnectionState.Connected) { Lnisstop = true; await Log("XIVLN stoped."); return; }
                //  --Updates--
                if (have_Updates)
                {
                    List<LodestoneNews> List_Updates = JsonConvert.DeserializeObject<List<LodestoneNews>>(jsonUpdates);

                    if (Config.Ids.Update_last_id == "0")
                    {
                        Config.Ids.Update_last_id = List_Updates[XIVLN.Config.MaxNewsOnFirst].Id;
                        await Config_Save();
                    }

                    if (Config.Ids.Update_last_id != List_Updates.First().Id)
                    {

                        int howMany = 0;

                        foreach (LodestoneNews item in List_Updates)
                        {
                            if (item.Id == Config.Ids.Update_last_id) { break; } else { howMany++; }
                        }

                        SocketTextChannel _channel = Kuru.GetTextChannel(Config.Channels.Update_channel);

                        for (int i = 0; i < howMany; i++)
                        {
                            string end_desc = NL + NL + "-# ";
                            string start_desc = $"### [{List_Updates[i].Title}]({List_Updates[i].Url})" + NL + NL;
                            end_desc += UnixTime(List_Updates[i].Time);

                            Embed embed = new EmbedBuilder()
                                            .WithTitle($"{Emote.Bot.LUpdate} Updates")
                                            .WithDescription(start_desc + List_Updates[i].Description + end_desc)
                                            .WithThumbnailUrl(XIVLN.Config.FFLogo)
                                            .WithColor(Color.Blue)
                                            .WithFooter(StringT.LN_from)
                            .Build();

                            if (_channel != null)
                            {
                                await _channel.SendMessageAsync("", embed: embed);
                                await Log($"XIVLodestoneNews => new update post: {List_Updates[i].Id}");
                            }
                            else
                            {
                                await ZenoLog($"Error trying send FFXIV_LN_Updates: {List_Updates[i].Id}. Channel is null {Emote.Bot.Sadtuff}");
                                await Log($"LodestoneNews: No channel on updates!!!");
                            }
                        }

                        Config.Ids.Update_last_id = List_Updates[0].Id;
                        await Config_Save();
                    }

                }

                if (Bot_Zeno.ConnectionState != ConnectionState.Connected) { Lnisstop = true; await Log("XIVLN stoped."); return; }
                //  --Notices--
                if (have_Notices)
                {
                    List<LodestoneNews> List_Notices = JsonConvert.DeserializeObject<List<LodestoneNews>>(json_Notices);

                    if (Config.Ids.Notices_last_id == "0")
                    {
                        Config.Ids.Notices_last_id = List_Notices[XIVLN.Config.MaxNewsOnFirst].Id;
                        await Config_Save();
                    }

                    if (Config.Ids.Notices_last_id != List_Notices.First().Id)
                    {

                        int howMany = 0;

                        foreach (LodestoneNews item in List_Notices)
                        {
                            if (item.Id == Config.Ids.Notices_last_id) { break; } else { howMany++; }
                        }

                        SocketTextChannel _channel = Kuru.GetTextChannel(Config.Channels.Notices_channel);


                        for (int i = 0; i < howMany; i++)
                        {
                            string end_desc = NL + NL + "-# ";
                            string start_desc = $"### [{List_Notices[i].Title}]({List_Notices[i].Url})" + NL + NL;
                            end_desc += UnixTime(List_Notices[i].Time);

                            Embed embed = new EmbedBuilder()
                                            .WithTitle($"{Emote.Bot.Lnotices} Notices")
                                            .WithDescription(start_desc + List_Notices[i].Description + end_desc)
                                            .WithThumbnailUrl(XIVLN.Config.FFLogo)
                                            .WithColor(Color.Blue)
                                            .WithFooter(StringT.LN_from)
                            .Build();

                            if (_channel != null)
                            {
                                await _channel.SendMessageAsync("", embed: embed);
                                await Log($"XIVLodestoneNews => new notice post: {List_Notices[i].Id}");
                            }
                            else
                            {
                                await ZenoLog($"Error trying send FFXIV_LN_Notices: {List_Notices[i].Id}. Channel is null {Emote.Bot.Sadtuff}");
                                await Log($"LodestoneNews: No channel on notices!!!");
                            }
                        }

                        Config.Ids.Notices_last_id = List_Notices[0].Id;
                        await Config_Save();
                    }
                }

                if (Bot_Zeno.ConnectionState != ConnectionState.Connected) { Lnisstop = true; await Log("XIVLN stoped."); return; }
                //  --Maintenance--
                if (have_Maintenance)
                {
                    List<LodestoneNews> List_Maintenance = JsonConvert.DeserializeObject<List<LodestoneNews>>(jsonMaintenance);

                    if (Config.Ids.Maintenance_last_id == "0")
                    {
                        Config.Ids.Maintenance_last_id = List_Maintenance[XIVLN.Config.MaxNewsOnFirst].Id;
                        await Config_Save();
                    }

                    if (Config.Ids.Maintenance_last_id != List_Maintenance.First().Id)
                    {

                        int howMany = 0;

                        foreach (LodestoneNews item in List_Maintenance)
                        {
                            if (item.Id == Config.Ids.Maintenance_last_id) { break; } else { howMany++; }
                        }

                        SocketTextChannel _channel = Kuru.GetTextChannel(Config.Channels.Maintenance_channel);

                        for (int i = 0; i < howMany; i++)
                        {
                            string end_desc = NL + NL + "-# ";
                            string start_desc = $"### [{List_Maintenance[i].Title}]({List_Maintenance[i].Url})" + NL + NL;
                            end_desc += UnixTime(List_Maintenance[i].Time);

                            Embed embed = new EmbedBuilder()
                                            .WithTitle($"{Emote.Bot.LMaintenance} Maintenance")
                                            .WithDescription(start_desc + List_Maintenance[i].Description + end_desc)
                                            .WithThumbnailUrl(XIVLN.Config.FFLogo)
                                            .WithColor(Color.Blue)
                                            .WithFooter(StringT.LN_from)
                            .Build();

                            if (_channel != null)
                            {
                                await _channel.SendMessageAsync("", embed: embed);
                                await Log($"XIVLodestoneNews => new mintenance post: {List_Maintenance[i].Id}");
                            }
                            else
                            {
                                await ZenoLog($"Error trying send FFXIV_LN_Maintenance: {List_Maintenance[i].Id}. Channel is null {Emote.Bot.Sadtuff}");
                                await Log($"LodestoneNews: No channel on maintenance!!!");
                            }
                        }

                        Config.Ids.Maintenance_last_id = List_Maintenance[0].Id;
                        await Config_Save();
                    }
                }

                //-------------------------------------- Maintenance Current
                if (Bot_Zeno.ConnectionState != ConnectionState.Connected) { Lnisstop = true; await Log("XIVLN stoped."); return; }
                //  --Game--
                if (have_Maintenance_Current)
                {
                    MaintenanceRoot List_Maintenance_Current = JsonConvert.DeserializeObject<MaintenanceRoot>(jsonMaintenance_Current);
                    //Print($"RootMant {List_Maintenance_Current.Game.Count.ToString()}");
                    SocketTextChannel _channel = Kuru.GetTextChannel(Config.Channels.Maintenance_channel);

                    if (List_Maintenance_Current.Game.Count > 0)
                    {


                        if (Config.Ids.Maintenance_last_game_id != List_Maintenance_Current.Game.First().Id)
                        {

                            int howMany = 0;

                            foreach (MaintenanceEvent item in List_Maintenance_Current.Game)
                            {
                                if (item.Id == Config.Ids.Maintenance_last_game_id) { break; } else { howMany++; }
                            }

                            for (int i = 0; i < howMany; i++)
                            {
                                string st = UnixTime(DateTime.Parse(List_Maintenance_Current.Game[i].Start));
                                string et = UnixTime(DateTime.Parse(List_Maintenance_Current.Game[i].End));
                                string tt = UnixTime(DateTime.Parse(List_Maintenance_Current.Game[i].Time));

                                var embed = new EmbedBuilder()
                                    .WithTitle($"{Emote.Bot.LMaintenance} Game maintenance.")
                                    .WithUrl(List_Maintenance_Current.Game[i].Url)
                                    .WithDescription("### " + List_Maintenance_Current.Game[i].Title + NL + NL + $"-# {tt}")
                                    .AddField($"Start time: {NL + UnixTime(DateTime.Parse(List_Maintenance_Current.Game[i].Start), "d") + NL + UnixTime(DateTime.Parse(List_Maintenance_Current.Game[i].Start), "t")}", st, true)
                                    .AddField($"End time: {NL + UnixTime(DateTime.Parse(List_Maintenance_Current.Game[i].End), "d") + NL + UnixTime(DateTime.Parse(List_Maintenance_Current.Game[i].End), "t")}", et, true)
                                    .WithColor(Color.Blue)
                                    .WithFooter(StringT.LN_from)
                                    .Build();

                                if (_channel != null)
                                {
                                    await _channel.SendMessageAsync("", embed: embed);
                                    await Log($"XIVLodestoneNews => new game maintenance post: {List_Maintenance_Current.Game[i].Id}");
                                }
                                else
                                {
                                    await ZenoLog($"Error trying send FFXIV_LN_Maintenance: {List_Maintenance_Current.Game[i].Id}. Channel is null {Emote.Bot.Sadtuff}");
                                    await Log($"LodestoneNews: No channel on maintenance current game!!!");
                                }
                            }

                            Config.Ids.Maintenance_last_game_id = List_Maintenance_Current.Game[0].Id;
                            await Config_Save();
                        }
                    }
                    else
                    {
                        Config.Ids.Maintenance_last_game_id = "0";
                        await Config_Save();
                    }

                    //  --Lodestone--
                    if (List_Maintenance_Current.Lodestone.Count > 0)
                    {
                        if (Config.Ids.Maintenance_last_lodestone_id != List_Maintenance_Current.Lodestone.First().Id)
                        {

                            int howMany = 0;

                            foreach (MaintenanceEvent item in List_Maintenance_Current.Lodestone)
                            {
                                if (item.Id == Config.Ids.Maintenance_last_lodestone_id) { break; } else { howMany++; }
                            }

                            for (int i = 0; i < howMany; i++)
                            {
                                string st = UnixTime(DateTime.Parse(List_Maintenance_Current.Lodestone[i].Start));
                                string et = UnixTime(DateTime.Parse(List_Maintenance_Current.Lodestone[i].End));
                                string tt = UnixTime(DateTime.Parse(List_Maintenance_Current.Lodestone[i].Time));

                                var embed = new EmbedBuilder()
                                    .WithTitle($"{Emote.Bot.LMaintenance} Lodestone maintenance.")
                                    .WithUrl(List_Maintenance_Current.Lodestone[i].Url)
                                    .WithDescription("### " + List_Maintenance_Current.Lodestone[i].Title + NL + NL + $"-# {tt}")
                                    .AddField($"Start time: {NL + UnixTime(DateTime.Parse(List_Maintenance_Current.Lodestone[i].Start), "d") + NL + UnixTime(DateTime.Parse(List_Maintenance_Current.Lodestone[i].Start), "t")}", st, true)
                                    .AddField($"End time: {NL + UnixTime(DateTime.Parse(List_Maintenance_Current.Lodestone[i].End), "d") + NL + UnixTime(DateTime.Parse(List_Maintenance_Current.Lodestone[i].End), "t")}", et, true)
                                    .WithColor(Color.Blue)
                                    .WithFooter(StringT.LN_from)
                                    .Build();

                                if (_channel != null)
                                {
                                    await _channel.SendMessageAsync("", embed: embed);
                                    await Log($"XIVLodestoneNews => new lodestone maintenance post: {List_Maintenance_Current.Lodestone[i].Id}");
                                }
                                else
                                {
                                    await ZenoLog($"Error trying send FFXIV_LN_Maintenance: {List_Maintenance_Current.Lodestone[i].Id}. Channel is null {Emote.Bot.Sadtuff}");
                                    await Log($"LodestoneNews: No channel on maintenance current lodestone!!!");
                                }
                            }

                            Config.Ids.Maintenance_last_lodestone_id = List_Maintenance_Current.Lodestone[0].Id;
                            await Config_Save();
                        }
                    }
                    else
                    {
                        Config.Ids.Maintenance_last_lodestone_id = "0";
                        await Config_Save();
                    }


                    //  --Mog--
                    if (List_Maintenance_Current.Mog.Count > 0)
                    {
                        if (Config.Ids.Maintenance_last_mog_id != List_Maintenance_Current.Mog.First().Id)
                        {

                            int howMany = 0;

                            foreach (MaintenanceEvent item in List_Maintenance_Current.Mog)
                            {
                                if (item.Id == Config.Ids.Maintenance_last_mog_id) { break; } else { howMany++; }
                            }

                            for (int i = 0; i < howMany; i++)
                            {
                                string st = UnixTime(DateTime.Parse(List_Maintenance_Current.Mog[i].Start));
                                string et = UnixTime(DateTime.Parse(List_Maintenance_Current.Mog[i].End));
                                string tt = UnixTime(DateTime.Parse(List_Maintenance_Current.Mog[i].Time));

                                var embed = new EmbedBuilder()
                                    .WithTitle($"{Emote.Bot.LMaintenance} Mog maintenance.")
                                    .WithUrl(List_Maintenance_Current.Mog[i].Url)
                                    .WithDescription("### " + List_Maintenance_Current.Mog[i].Title + NL + NL + $"-# {tt}")
                                    .AddField($"Start time: {NL + UnixTime(DateTime.Parse(List_Maintenance_Current.Mog[i].Start), "d") + NL + UnixTime(DateTime.Parse(List_Maintenance_Current.Mog[i].Start), "t")}", st, true)
                                    .AddField($"End time: {NL + UnixTime(DateTime.Parse(List_Maintenance_Current.Mog[i].End), "d") + NL + UnixTime(DateTime.Parse(List_Maintenance_Current.Mog[i].End), "t")}", et, true)
                                    .WithColor(Color.Blue)
                                    .WithFooter(StringT.LN_from)
                                    .Build();

                                if (_channel != null)
                                {
                                    await _channel.SendMessageAsync("", embed: embed);
                                    await Log($"XIVLodestoneNews => new game mog post: {List_Maintenance_Current.Mog[i].Id}");
                                }
                                else
                                {
                                    await ZenoLog($"Error trying send FFXIV_LN_Maintenance: {List_Maintenance_Current.Mog[i].Id}. Channel is null {Emote.Bot.Sadtuff}");
                                    await Log($"LodestoneNews: No channel on maintenance current mog!!!");
                                }
                            }

                            Config.Ids.Maintenance_last_mog_id = List_Maintenance_Current.Mog[0].Id;
                            await Config_Save();
                        }
                    }
                    else
                    {
                        Config.Ids.Maintenance_last_mog_id = "0";
                        await Config_Save();

                    }


                    //  --Companion--
                    if (List_Maintenance_Current.Companion.Count > 0)
                    {
                        if (Config.Ids.Maintenance_last_companion_id != List_Maintenance_Current.Companion.First().Id)
                        {

                            int howMany = 0;

                            foreach (MaintenanceEvent item in List_Maintenance_Current.Companion)
                            {
                                if (item.Id == Config.Ids.Maintenance_last_companion_id) { break; } else { howMany++; }
                            }

                            for (int i = 0; i < howMany; i++)
                            {
                                string st = UnixTime(DateTime.Parse(List_Maintenance_Current.Companion[i].Start));
                                string et = UnixTime(DateTime.Parse(List_Maintenance_Current.Companion[i].End));
                                string tt = UnixTime(DateTime.Parse(List_Maintenance_Current.Companion[i].Time));

                                var embed = new EmbedBuilder()
                                    .WithTitle($"{Emote.Bot.LMaintenance} Companion maintenance.")
                                    .WithUrl(List_Maintenance_Current.Companion[i].Url)
                                    .WithDescription("### " + List_Maintenance_Current.Companion[i].Title + NL + NL + $"-# {tt}")
                                    .AddField($"Start time: {NL + UnixTime(DateTime.Parse(List_Maintenance_Current.Companion[i].Start), "d") + NL + UnixTime(DateTime.Parse(List_Maintenance_Current.Companion[i].Start), "t")}", st, true)
                                    .AddField($"End time: {NL + UnixTime(DateTime.Parse(List_Maintenance_Current.Companion[i].End), "d") + NL + UnixTime(DateTime.Parse(List_Maintenance_Current.Companion[i].End), "t")}", et, true)
                                    .WithColor(Color.Blue)
                                    .WithFooter(StringT.LN_from)
                                    .Build();

                                if (_channel != null)
                                {
                                    await _channel.SendMessageAsync("", embed: embed);
                                    await Log($"XIVLodestoneNews => new maintence companion post: {List_Maintenance_Current.Companion[i].Id}");
                                }
                                else
                                {
                                    await ZenoLog($"Error trying send FFXIV_LN_Maintenance: {List_Maintenance_Current.Companion[i].Id}. Channel is null {Emote.Bot.Sadtuff}");
                                    await Log($"LodestoneNews: No channel on maintenance current companion!!!");
                                }
                            }

                            Config.Ids.Maintenance_last_companion_id = List_Maintenance_Current.Companion[0].Id;
                            await Config_Save();
                        }
                    }
                    else
                    {

                        Config.Ids.Maintenance_last_companion_id = "0";
                        await Config_Save();

                    }

                }

                await LogExtra($"XIVLN next check on: {XIVLN.Config.TimerInterval} ms");

                XIV_Timer.Change(XIVLN.Config.TimerInterval, Timeout.Infinite); //reset timer

            }
            catch (Exception ex)
            {
                await LogError(ex.Message);
                XIV_Timer.Change(Timeout.Infinite, Timeout.Infinite);
                Config.XIV_LN_enabled = false;
                Lnisstop = true;
            }

            XIV_Timer.Change(Timeout.Infinite, Timeout.Infinite);
            Config.XIV_LN_enabled = false;
            Lnisstop = true;

        }

    }
}
