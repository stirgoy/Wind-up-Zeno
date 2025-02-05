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
    public partial class AddRoleForm : Form
    {
        public AddRoleForm()
        {
            InitializeComponent();
        }

        private void AddRoleForm_Load(object sender, EventArgs e)
        {
            Text = $"Add roles to {User.DisplayName}";
            Icon = Program.ZenoForm.Icon;
            UpdateList();

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void BtnAddRole_Click(object sender, EventArgs e)
        {

            var res = MessageBox.Show($"Are you sure you want add:{NL}user: {User.DisplayName + NL} to role: {LstRoles.SelectedItem}", "Role manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult== DialogResult.No) { return; }
            await User.AddRoleAsync(LstRoles.SelectedItem as SocketRole);
            UpdateList();
        }

        private void UpdateList()
        {
            LstRoles.Items.Clear();
            var nonRoles = Core.Bot.GetKuruRoles();

            foreach (var item in nonRoles)
            {
                if (!User.Roles.Contains(item))
                {
                    LstRoles.Items.Add(item);
                }
            }

            if (LstRoles.Items.Count > 0) { LstRoles.SelectedIndex = 0; } else { BtnAddRole.Enabled = false; }
        }
    }
}
