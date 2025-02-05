using Discord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wind_up_Zeno
{
    internal class CloseMe { }
    public partial class FormMain
    {
        private async Task CloseMe()
        {
            AbleToClose = true;
            if (Core.Bot.IsOnline() == ConnectionState.Connected) await Core.Bot.StopBot();
            NI.Visible = false;
            Close();

        }
    }
}
