using Discord;
using Discord.WebSocket;
using System;
using System.Threading.Tasks;

namespace Wind_up_Zeno
{
    public partial class Zeno
    {
        //cacpot is at 19:00 UTC
        //const int hour = 19; //UTC 0
        const DayOfWeek dow = DayOfWeek.Saturday;
        public bool CacpotRunning = false;

        public async void Cacpot()
        {
            if (CacpotRunning) 
            { 
                return; 
            }
            else
            {
                CacpotRunning = true;
            }


            //DateTimeOffset now = new DateTimeOffset(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, 0, 0, TimeSpan.Zero);
            DateTimeOffset now = DateTimeOffset.UtcNow;
            //now = now.ToLocalTime();

            if (Config.LastCacpot == "") //no data, lets take same day
            {                
                string snow = now.ToString("dd/MM/yyyy HH:mm");
                await Config_Save();
                Config.LastCacpot = snow;
            }

            await LogForm($"Cacpot set for: {dow} at {Config.FF_Schedules[3]}:00");

            while (CacpotRunning) //hate you
            {
                Cacisstop = false;

                now = DateTimeOffset.UtcNow;

                //DateTime now = DateTime.Now;
                if (now.DayOfWeek == dow && now.Hour == Config.FF_Schedules[3])
                { //is saturday and its 20:00

                    //DateTime last = DateTime.Parse(Config.LastCacpot);
                    await Config_Load();
                    DateTimeOffset last = DateTimeOffset.Parse(Config.LastCacpot);

                    if (last.UtcDateTime.Date < now.UtcDateTime.Date)
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
                            UpdateControls();
                        }

                        Config.LastCacpot = now.ToString("dd/MM/yyyy HH") + ":00";
                        await Config_Save();

                    }

                }

                await Task.Delay(Config.CacpotLoopDelay);
            }

            await LogForm("Cacpot is stoped");
            CacpotRunning = false;
            Cacisstop = true;

        }
    }
}
