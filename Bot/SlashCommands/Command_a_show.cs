using Discord.WebSocket;
using System.IO;
using System.Threading.Tasks;

namespace Wind_up_Zeno
{
    public partial class Zeno
    {
        private async Task Command_a_show_stored(SocketSlashCommand command)
        {
            await command.DeferAsync(ephemeral: true);

            string jsoncfg = File.ReadAllText($"{Path}\\{Json_file}");
            jsoncfg = $"There is my persistent data => kuru.json:{NL}```{jsoncfg}```";

            var m1 = await command.FollowupAsync(jsoncfg, ephemeral: true);
            BorrarMsg(m1, 60);
        }
    }
}
