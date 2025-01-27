using Discord;
using Discord.WebSocket;
using System;
using System.Threading.Tasks;

namespace Wind_up_Zeno
{
    public partial class Zeno
    {
        //
        const int hour = 19;
        const DayOfWeek dow = DayOfWeek.Saturday;
        public bool CacpotRunning = false;

        public async void Cacpot()
        {
            if (CacpotRunning) { return; }

            CacpotRunning = true;

            DateTimeOffset now = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hour,0,0,DateTimeKind.Utc);
            now = now.ToLocalTime();

            if (Config.LastCacpot == "") //no data, lets take same day
            {                
                string snow = now.ToString("dd/MM/yyyy HH:mm");
                await Config_Save();
                Config.LastCacpot = snow;
            }

            await LogForm($"Cacpot started for: {now.Hour}:00");

            while (CacpotRunning) //hate you
            {
                cacisstop = false;
                //DateTime now = DateTime.Now;
                if (now.DayOfWeek == dow && now.Hour == hour)
                { //is saturday and its 20:00

                    DateTime last = DateTime.Parse(Config.LastCacpot);

                    if (last.Date < now.Date)
                    {
                        await Log("CACPOT READY SENDING MESSAGES!!!!");
                        // last notice < today for prevent multi advise
                        //await Kuru.DownloadUsersAsync(); //download all server users

                        foreach (string user in Config.CacpotIds)
                        {
                            ulong uid = ulong.Parse(user);
                            Kuru.GetUsersAsync(); //hmmm...
                            SocketGuildUser bdy = Kuru.GetUser(uid);
                            IDMChannel dm = await bdy.CreateDMChannelAsync();

                            Embed emb = CreateEmbed(
                                StringT.Cac_dm_title,
                                StringT.Ca_dm_desc,
                                miniImage: "https://i.postimg.cc/13dZCL3P/zenosxD.png",
                                color: Color.Green);


                            await dm.SendMessageAsync($"", embed: emb);
                            await dm.SendMessageAsync($"{Emote.Bot.Pepo_laugh}");

                            await Log($"Cacpot DM sent to: {bdy.GlobalName}");
                        }

                        Config.LastCacpot = now.ToString("dd/MM/yyyy HH:mm");
                        await Config_Save();

                    }

                }

                await Task.Delay(5 * 1000);
            }

            await LogForm("Cacpot is stoped");
            cacisstop = true;

        }
    }
}
