using Discord;
using Discord.WebSocket;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Wind_up_Zeno
{
    public partial class Zeno
    {
        private async Task Command_timestamp(SocketSlashCommand command)
        {
            var msg = command.Data.Options.FirstOrDefault(opt => opt.Name == "time");
            if (msg?.Value is string user_msg) { } else { return; }//exit on fail

            await command.DeferAsync(ephemeral: true);

            if (string.IsNullOrEmpty(user_msg))
            {
                await command.RespondAsync(StringT.Msg_err1_timestamp, ephemeral: true);
                return;
            }

            if (!DateTime.TryParse(user_msg, out DateTime parsedDate))
            {
                await command.RespondAsync(StringT.Msg_err1_timestamp, ephemeral: true);
                return;
            }

            long unixTimestamp = new DateTimeOffset(parsedDate).ToUnixTimeSeconds();
            string discordTimestamp = $"<t:{unixTimestamp}:R>";

            Embed talkc_embT = CreateEmbedField_1(
                StringT.Embed_timestamp_t,
                StringT.Embed_timestamp_d,
                discordTimestamp, $"`{discordTimestamp}`",
                StringT.Embed_timestamp_f,
                color: Color.Green);


            await command.FollowupAsync("", embed: talkc_embT, ephemeral: true);

        }
    }
}
