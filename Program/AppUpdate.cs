using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wind_up_Zeno
{
    public class AppUpdate { }

    public partial class FormMain
    {
        public void AppUpdate()
        {
            if (Disposing|| IsDisposed) { return; }

            bool online = Core.Bot.IsOnline() == Discord.ConnectionState.Connected;

            LstUsers.DisplayMember = "";

            LstUsers.DataSource = null;
            LstRoles.DataSource = null;
            //LstEmotes.DataSource = null;


            LstUsers.Items.Clear();
            LstChannels.Items.Clear();
            LstRoles.Items.Clear();
            LstEmotes.Items.Clear();

            BtnUserForm.Text = "";
            TxtStatus.Text = "";
            LblCacpot.Text = "Offline";

            if (online)
            {
                LstUsers.DisplayMember = "DisplayName";
                LstUsers.DataSource = Core.Bot.GetKuruUsers().ToArray();
                LstChannels.Items.AddRange(Core.Bot.GetKuruChannels().ToArray());
                LstRoles.DataSource = Core.Bot.GetKuruRoles().ToArray();
                var cac = Core.Bot.GetCacpotData();
                LblCacpot.Text = $"Last reminder: {cac[0] + NL}Users on list: {cac[1]}";

                Core.Emotes = Core.Bot.GetEmotes();

                foreach (var item in Core.Emotes)
                {
                    LstEmotes.Items.Add(item.Key);
                }

                TxtStatus.Text = Core.Bot.GetStatus();

            }

            if (LstUsers.Items.Count > 0) { LstUsers.SelectedIndex = 0; }
            if (LstChannels.Items.Count > 0) { LstChannels.SelectedIndex = 0; }
            if (LstRoles.Items.Count > 0) { LstRoles.SelectedIndex = 0; }
            if (LstEmotes.Items.Count > 0) { LstEmotes.SelectedIndex = 0; }

            BtnStart.Enabled = !online;
            BtnStop.Enabled = online;
            BtnUpdateLists.Enabled = online;
            BtnSendMsg.Enabled = online;
            BtnUserForm.Enabled = online;
            BtnAddU.Enabled = online;
            BtnAddC.Enabled = online;
            BtnCopyMC.Enabled = online;
            BtnCopyUM.Enabled = online;

        }



    }
}
