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
        /********************
                MassDelete
        *//////////////////// be careful
        private static async void MassDelete(SocketMessage message, int howmany)
        {
            var channel = message.Channel;
            var mensajes = await channel.GetMessagesAsync(howmany).FlattenAsync();
            foreach (var item in mensajes)
            {
                await item.DeleteAsync();
                await Task.Delay(750);
            }

            string log = $"{message.Author.GlobalName} used mass delete {howmany} times on {Kuru.GetTextChannel(channel.Id).Name}";
            string logz = $"{message.Author.Mention} used mass delete {howmany} times on {Kuru.GetTextChannel(channel.Id).Mention}";
            await Log(log);
            await ZenoLog(logz);

        }
    }
}
