using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wind_up_Zeno
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            UpdateLbl();
            UpdateRoleList();
            LstPermissions.DataSource = User.GuildPermissions.ToList();
            foreach (var item in User.GuildPermissions.ToList())
            {
                
            }
            Icon = Program.ZenoForm.Icon;
        }

        private void UpdateRoleList()
        {
            LstRoles.DataSource = null;
            LstRoles.Items.Clear();
            LstRoles.DataSource = User.Roles.ToList();
        }

        private void UpdateLbl()
        {
            var jat = (DateTimeOffset)User.JoinedAt;
            
            Text = User.DisplayName;

            string d = $"Display name: {User.DisplayName + NL}";
            d += $"Discord name: {User.Username + NL}";
            d += $"uid: {User.Id + NL}";
            d += $"Hierarchy: {User.Hierarchy + NL}";
            d += $"Created acc at: {User.CreatedAt.DateTime.ToShortDateString()} | {User.CreatedAt.DateTime.ToShortTimeString() + NL}";
            d += $"Joined server at: {jat.DateTime.ToShortDateString()} | {jat.DateTime.ToShortTimeString() + NL}";
            d += $"Admin: {User.GuildPermissions.Administrator + NL}";
            d += $"Bot: {User.IsBot + NL}";

            LblName.Text = d;

        }

        private void BtnAddRole_Click(object sender, EventArgs e)
        {
            var addroleform = new AddRoleForm();
            addroleform.User = User;
            addroleform.ShowDialog();
            UpdateRoleList();
            //TODO new form
        }

        private async void BtnRemoveRole_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show($"Are you sure you want remove the {NL}user: {User.DisplayName + NL} from role: {LstRoles.SelectedItem}", "Role manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                BtnRemoveRole.Enabled = false;
                if (LstRoles.Items[LstRoles.SelectedIndex] is SocketRole roleonlist)
                await User.RemoveRoleAsync(roleonlist);
                await Core.Bot.LogForm($"User: {User.DisplayName} is removed from role: {LstRoles.SelectedItem}");
                UpdateRoleList();

            }
        }

        private void LstRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstRoles.SelectedIndex > -1)
            {
                if(LstRoles.SelectedItem is SocketRole role)
                {                    
                    if(role.Name == "@everyone")
                    {
                        BtnRemoveRole.Enabled = false;
                    }
                    else
                    {
                        BtnRemoveRole.Enabled = true;
                    }
                }
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
