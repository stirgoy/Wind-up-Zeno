using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wind_up_Zeno
{
    public partial class Zeno
    {
        internal async Task ReadyAsync()
        {            

            Kuru = Bot_Zeno.Guilds.First();

            if (Kuru == null)
            {
                await LogError("The bot is not connected to server.");
                return;
            }

            await Log($"Connectd on: {Kuru.Name}");

            await Kuru.DownloadUsersAsync(); //users cache

            string tc = "";
            if (Config.Channels.TalkChannel != null)
            {
                if (Config.Channels.TalkChannel.Count >= 1)
                {
                    foreach (string item in Config.Channels.TalkChannel)
                    {
                        tc += $"{Kuru.GetChannel(ulong.Parse(item))}, ";
                    }
                    tc = tc.Remove(tc.Length - 2);
                    tc += ".";
                }
            }

            await Log($"Name: {Bot_Zeno.CurrentUser.Username}");
            await Log($"Id: {Bot_Zeno.CurrentUser.Id}");
            await Log($"Latency: {Bot_Zeno.Latency}");
            await Log($"Token: {Bot_Zeno.TokenType}");
            await Log($"Veryfed: {Bot_Zeno.CurrentUser.IsVerified}");
            await Log($"On: {Bot_Zeno.Guilds.Count} server/s");
            await Log($"Online on: {Kuru.Name}({Kuru.Id})");
            await Log($"Talk channel/s: {tc}");
            await Log($"Log channel: {Config.Channels.LogChannel} - {Kuru.GetChannel(Config.Channels.LogChannel)}");

            if (!string.IsNullOrEmpty(Config.Playing))
            {
                await Bot_Zeno.SetCustomStatusAsync(Config.Playing);
            }

            try
            {
                if (Config.UpdateSlashCommands)
                {
                    await Kuru.BulkOverwriteApplicationCommandAsync(ZenosSlashCommands.Zenos_SC);
                    await Log("Application Commands registered successfully!");
                }
                else
                {
                    await Log("ATENTION - BulkOverwriteApplicationCommandAsync skipped!");
                }
            }
            catch (Exception ex)
            {
                await Log($"Error loading commands: {ex.Message}");
            }

            try
            {
                UpdateControls();
            }
            catch (Exception ex)
            {
                await Log($"ZenoFormCall(): {ex.Message}");
            }

            try
            {
                XIV_LN(); //news updater
                Cacpot(); //cacpot dm noticer
            }
            catch (Exception ex)
            {                
                await Log($"Error on back tasks: {ex.Message}");
            }

            

        }

        

    }
}
