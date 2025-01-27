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

            LstRoles.DataSource = User.Roles.ToList();


        }
    }
}
