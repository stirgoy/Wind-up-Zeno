using Discord;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wind_up_Zeno
{
    public partial class Zeno
    {
        private async Task Command_a_status(SocketSlashCommand command)
        {
            await command.DeferAsync(ephemeral:true);

            var param = command.Data.Options.FirstOrDefault(opt => opt.Name == "status");
            if (param?.Value is string status) { } else { return; }


            Config.Playing = status;
            await Config_Save();
            await Bot_Zeno.SetCustomStatusAsync(status);
            UpdateControls();

            var emb = CreateEmbed($"Custom status", $"My custom status is set to: {status}", color: Color.Gold);
            await command.FollowupAsync("",embed: emb, ephemeral: true);
            BorrarMsg(15);

        }
    }
}
