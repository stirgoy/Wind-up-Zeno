using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wind_up_Zeno
{
    public partial class Zeno
    {
        /********************
            Reconnect
        *//////////////////// client reconnection
        private static async void Reconnect()
        {
            try
            {
                await Core.Bot.StopBot();

                await Task.Delay(1000);

                await Core.Bot.RunBot();
            }
            catch (Exception ex)
            {
                await LogError(ex.Message);
            }
        }
    }
}
