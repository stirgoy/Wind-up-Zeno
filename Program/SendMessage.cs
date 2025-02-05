using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wind_up_Zeno
{
    internal class SendMessage { }

    public partial class FormMain
    {
        private async void SendMessage()
        {
            string m = "";
            bool run = true;
            if (!ChkSendTo.Checked)
            {

                if (LstUsers.Items.Count <= 0)
                {
                    m = "There is no users for send message.";
                    run = false;
                }
                else if (LstUsers.SelectedIndex == -1)
                {
                    m = "You need to select any user from list";
                    run = false;
                }
                else if (TxtMsg.Text == "")
                {
                    m = "Message can't be empty";
                    run = false;
                }

                if (run)
                {
                    if (LstUsers.Items[LstUsers.SelectedIndex] != null)
                    {
                        var u = LstUsers.Items[LstUsers.SelectedIndex] as SocketGuildUser;
                        var dm = await u.CreateDMChannelAsync();
                        await dm.SendMessageAsync(TxtMsg.Text);
                        await Core.Bot.LogForm($"Message sent from app to {u.DisplayName}");
                    }
                }
                else
                {
                    MessageBox.Show(m, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (LstChannels.Items.Count <= 0)
                {
                    m = "There is no channels for send message.";
                    run = false;
                }
                else if (LstChannels.SelectedIndex == -1)
                {
                    m = "You need to select any channel from list";
                    run = false;
                }
                else if (TxtMsg.Text == "")
                {
                    m = "Message can't be empty";
                    run = false;
                }

                if (run)
                {
                    if (LstChannels.Items[LstChannels.SelectedIndex] != null)
                    {
                        var c = LstChannels.Items[LstChannels.SelectedIndex] as SocketTextChannel;
                        await c.SendMessageAsync(TxtMsg.Text);
                        await Core.Bot.LogForm($"Message sent from app to {c.Name}");
                    }
                }
                else
                {
                    MessageBox.Show(m, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
