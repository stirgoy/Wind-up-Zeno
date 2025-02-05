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
        public bool Cacisstop = false;
        public static bool Lnisstop { get; set; } = false;

        public async Task StopBot()
        {
            try
            {                
                await Bot_Zeno.LogoutAsync();
                await Bot_Zeno.StopAsync();
                StopXIVLN();
                CacpotRunning = false;
                await LogForm("Waiting for background tasks to end...");
                while (!Cacisstop || !Lnisstop) { await Task.Delay(500); }
                UpdateControls();
                await LogForm($"Bot totally off");
            }
            catch (Exception )
            {
                //await LogError(ex.Message);
            }
        }
    }
}
