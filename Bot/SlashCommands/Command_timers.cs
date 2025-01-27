using Discord;
using Discord.WebSocket;
using System;
using System.Threading.Tasks;

namespace Wind_up_Zeno
{
    public partial class Zeno
    {
        private async Task Command_timers(SocketSlashCommand command)
        {
            await command.DeferAsync(ephemeral: false);

            DateTime ahora = DateTime.Now;
            bool isDST = !ahora.IsDaylightSavingTime();
            /*
            //dst handler
            int weekly_hour = isDST ? 10 : 9;
            int daily_hour = isDST ? 17 : 16;
            int GC_hour = isDST ? 22 : 21;
            //int Cac_hour = isDST ? 19 : 19;
            */
            //UTC hours
            const int weekly_hour = 8;
            const int daily_hour = 15;
            const int GC_hour = 20;
            const int Cac_hour = 19;

            // Weekly timer
            DateTime weekly = new DateTime(ahora.Year, ahora.Month, ahora.Day, weekly_hour, 0, 0,DateTimeKind.Utc)
                .AddDays(((int)DayOfWeek.Tuesday - (int)ahora.DayOfWeek + 7) % 7);
            if (ahora >= weekly) weekly = weekly.AddDays(7); //move to next tuesday if passed
            DateTimeOffset weekly_l = weekly.ToLocalTime();
            long unixW = weekly_l.ToUnixTimeSeconds();
            string weeklyDT = $"<t:{unixW}:R>";

            // Daily timer
            DateTime daily = new DateTime(ahora.Year, ahora.Month, ahora.Day, daily_hour, 0, 0, DateTimeKind.Utc);
            if (ahora >= daily) daily = daily.AddDays(1); //move to next day if passed
            DateTimeOffset daily_l = daily.ToLocalTime();
            long unixD = daily_l.ToUnixTimeSeconds();
            string dailyDT = $"<t:{unixD}:R>";

            // GC timer
            DateTime gc = new DateTime(ahora.Year, ahora.Month, ahora.Day, GC_hour, 0, 0, DateTimeKind.Utc);
            if (ahora >= gc) gc = gc.AddDays(1); //move to next day if passed
            DateTimeOffset gc_l= gc.ToLocalTime();
            long unixG = gc_l.ToUnixTimeSeconds();
            string gcDT = $"<t:{unixG}:R>";

            // Ocean Fishing timer
            DateTime ocean;
            if (isDST)
            { //pair
                ocean = new DateTime(ahora.Year, ahora.Month, ahora.Day, ahora.Hour, 0, 0, DateTimeKind.Utc).AddHours(2 - (ahora.Hour % 2));
            }
            else
            { //unpair
                ocean = new DateTime(ahora.Year, ahora.Month, ahora.Day, ahora.Hour, 0, 0, DateTimeKind.Utc).AddHours(ahora.Hour % 2 == 0 ? 1 : 2);
            }

            long unixO = new DateTimeOffset(ocean).ToUnixTimeSeconds();
            string oceanDT = $"<t:{unixO}:R>";

            // Cacpot Lottery timer
            DateTime cacpot = new DateTime(ahora.Year, ahora.Month, ahora.Day, Cac_hour, 0, 0, DateTimeKind.Utc)
                .AddDays(((int)DayOfWeek.Saturday - (int)ahora.DayOfWeek + 7) % 7);
            DateTimeOffset cacpot_l = cacpot.ToLocalTime();
            long unixC = cacpot_l.ToUnixTimeSeconds();
            string cacpotDT = $"<t:{unixC}:R>";

            long curt = new DateTimeOffset(DateTime.Now).ToUnixTimeSeconds();
            string timenow = $"<t:{curt}:R>";


            // Embed response
            var embed = new EmbedBuilder()
                .WithTitle($"Eorzean timers. " + Emote.Bot.FFXIV)
                .WithDescription(Emote.Bot.Sproud + " Because you looks lost. " + Emote.Bot.Sproud + NL + "-# " + timenow + NL)
                .WithColor(Color.Green)
                .AddField(Emote.Bot.MSQ + " Weekly", weeklyDT, true)
                .AddField(Emote.Bot.Roulette + " Daily", dailyDT, true)
                .AddField(Emote.Bot.Gc + " GC", gcDT, true)
                .AddField(Emote.Bot.Fishing + " Ocean fishing", oceanDT, true)
                .AddField(Emote.Bot.Cactuar + " Cacpot", cacpotDT, true)
                .Build();

            await command.FollowupAsync("", embed: embed);

        }
    }
}
