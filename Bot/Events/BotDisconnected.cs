using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wind_up_Zeno
{
    public partial class Zeno
    {
        public async Task BotDisconnected(Exception ex)
        {
            try
            {
                await Log($"Disconnected. Reason: {ex.Message}");
            }
            catch (Exception exe)
            {
                await LogError(exe.ToString());
            }
        }
    }
}
