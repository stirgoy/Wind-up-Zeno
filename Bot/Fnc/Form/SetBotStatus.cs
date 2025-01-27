using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wind_up_Zeno
{
    public partial class Zeno
    {
        public async Task SetBotStatus(string status)
        {
            Config.Playing = status;
            await Config_Save();
            await Bot_Zeno.SetCustomStatusAsync(status);
        }
    }
}
