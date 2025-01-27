using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Wind_up_Zeno
{
    public partial class Zeno
    {
        public bool cacisstop = false;
        public static bool lnisstop = false;

        public async Task StopBot()
        {
            try
            {                
                await Bot_Zeno.LogoutAsync();
                await Bot_Zeno.StopAsync();
                StopXIVLN();
                CacpotRunning = false;
                while (!cacisstop && !lnisstop) { await Task.Delay(500); }
                await LogForm("Bot Stoped.");
                UpdateControls();
            }
            catch (Exception )
            {
                //await LogError(ex.Message);
            }
        }
    }
}
