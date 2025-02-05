using Discord;
using Discord.WebSocket;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Wind_up_Zeno
{

    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            //            DisableControlsInit();
            NI.Icon = Icon;
            NI.Visible = true;
            NI.Text = Text;



            //bot instance
            ZenoInstance();

            await Core.Bot.LogForm("Loading Bot Zeno...");

            Core.Bot.CreateShortcut();
            await Core.Bot.PreLoad();

            IsUser = false;
            ChkAutostart.Checked = Core.Bot.GetAutostart();
            IsUser = true;
        }


        private async void FormMain_Shown(object sender, EventArgs e)
        {
#if DEBUG
            Text += " 🛠 (BEDUG)";
            BtnToggle_Click(sender, e);
#endif
            await Core.Bot.LogForm("Checking auto start...");

            if (ChkAutostart.Checked)
            {
                BtnStart_Click(sender, e);
            }
        }

        private async void BtnStop_Click(object sender, EventArgs e)
        {
            BtnStop.Enabled= false;
            await Core.Bot.StopBot();
            //ButtonStatus();
        }

        private async void BtnStart_Click(object sender, EventArgs e)
        {
            BtnStart.Enabled = false;
            await Core.Bot.RunBot();
        }


        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtLog.Text = "";
        }

        private void BtnUsers_Click(object sender, EventArgs e)
        {
            AppUpdate();
        }



        private void BtnLogs_Click(object sender, EventArgs e)
        {
            Run("explorer.exe", Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Zeno\\Logs"));
        }

        private void BtnData_Click(object sender, EventArgs e)
        {
            Run("explorer.exe", Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Zeno"));
        }



        private void LstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstUsers.SelectedIndex >= 0)
            {
                if (LstUsers.Items[LstUsers.SelectedIndex] is SocketGuildUser cuser)
                {
                    BtnUserForm.Text = $"{cuser.DisplayName}/{cuser}";
                    TxtMentionUser.Text = cuser.Mention;
                }
            }
        }


        private void BtnSendMsg_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        private void ChkAutostart_CheckedChanged(object sender, EventArgs e)
        {
            if (IsUser)
            {
                Core.Bot.ToggleAutostart();
            }
        }

        private void BtnUserForm_Click(object sender, EventArgs e)
        {
            if (LstUsers.Items.Count > 0)
            {
                if (LstUsers.SelectedIndex > -1)
                {
                    UserForm uf = new UserForm
                    {
                        User = (SocketGuildUser)LstUsers.Items[LstUsers.SelectedIndex]
                    };

                    uf.ShowDialog();
                }
            }


        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!AbleToClose)
            {
                e.Cancel = true;
                Visible = false;

            }
            else
            {
                e.Cancel = false;
            }
        }

        

        private void LstChannels_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstChannels.Items.Count > 0)
            {
                if (LstChannels.SelectedIndex > -1)
                {
                    if (LstChannels.Items[LstChannels.SelectedIndex] is SocketTextChannel stc)
                        TxtMentionChannel.Text = (stc.Mention);
                }
            }
        }

        private void BtnCopyUM_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TxtMentionUser.Text);
        }

        private void BtnCopyMC_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TxtMentionChannel.Text);
        }


        private void BtnCopyRM_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TxtRM.Text);
        }

        private void BtnCopyE_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TxtEmotes.Text);
        }
        private void BtnAddU_Click(object sender, EventArgs e)
        {
            TxtMsg.Text += TxtMentionUser.Text;
        }

        private void BtnAddC_Click(object sender, EventArgs e)
        {
            TxtMsg.Text += TxtMentionChannel.Text;
        }

        private void BtnAddR_Click(object sender, EventArgs e)
        {
            TxtMsg.Text += TxtRM.Text;
        }

        private void BtnAddE_Click(object sender, EventArgs e)
        {
            TxtMsg.Text += TxtEmotes.Text;
        }

        private void LstRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstRoles.Items.Count > 0)
            {
                if (LstRoles.SelectedIndex > -1)
                {
                    TxtRM.Text = (LstRoles.Items[LstRoles.SelectedIndex] as SocketRole).Mention;
                }
            }
        }

        private async void BtnStatus_Click(object sender, EventArgs e)
        {
            if (TxtStatus.Text.Length <= 128)
            {
                if (Core.Bot.IsOnline() == ConnectionState.Connected)
                {
                    await Core.Bot.SetBotStatus(TxtStatus.Text);
                }
            }
            else
            {
                MessageBox.Show($"Maximum length its 128 characters, you have typed: {TxtStatus.Text.Length}", "Overflow error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LstEmotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstEmotes.Items.Count > 0)
            {
                if (LstEmotes.SelectedIndex > -1)
                {
                    if (Core.Emotes.ContainsKey(LstEmotes.SelectedItem.ToString()))
                    {
                        TxtEmotes.Text = Core.Emotes[LstEmotes.SelectedItem.ToString()];
                    }
                }
            }
        }

        private async void BtnClose_Click(object sender, EventArgs e)
        {
            await CloseMe();
        }

        private void NI_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Visible = !Visible;
        }

        
        private void BtnToggle_Click(object sender, EventArgs e)
        {
            if (ConsoleFull)
            {
                TxtLog.Location = new System.Drawing.Point() { X = TxtLog.Location.X, Y = TxtLog.Location.Y + DIF };
                TxtLog.Height -= DIF;
            }
            else
            {
                TxtLog.Location = new System.Drawing.Point() { X = TxtLog.Location.X, Y = TxtLog.Location.Y - DIF };
                TxtLog.Height += DIF;
            }
            ConsoleFull = !ConsoleFull;
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            if (Core.Bot.IsOnline() == ConnectionState.Disconnected)
            {

                var s = OFD.ShowDialog();
                if (s == DialogResult.OK)
                {
                    if (File.Exists(OFD.FileName))
                    {
                        string zpath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Zeno\\kuru.json";
                        if (File.Exists(zpath))
                        {
                            File.Replace(OFD.FileName, zpath, zpath);
                        }
                        else
                        {
                            File.Copy(OFD.FileName, zpath);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("For import configuration bot need be offline.", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void ChkExtraLog_CheckedChanged(object sender, EventArgs e)
        {
            Core.ExtraLog = ChkExtraLog.Checked;
        }

        private void BtnRoles_Click(object sender, EventArgs e)
        {
            var formrole = new RolesForm();
            formrole.ShowDialog();
        }

        private void BtnSchedulesForm_Click(object sender, EventArgs e)
        {
            var formrole = new SchedulesForm();
            formrole.ShowDialog();
        }
    }



}
