using System;
using System.Windows.Forms;

namespace Wind_up_Zeno
{
    public partial class TokenForm : Form
    {
        public TokenForm()
        {
            InitializeComponent();
        }
                

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {

                if (TxtToken.Text != "")
                {
                    BtnOk.Enabled = false;
#if DEBUG
                    Environment.SetEnvironmentVariable("ZenosT", TxtToken.Text, EnvironmentVariableTarget.User);
#else
                    Environment.SetEnvironmentVariable("WUZenosT", TxtToken.Text , EnvironmentVariableTarget.User);
#endif
                    Close();
                }
            }
            catch (Exception ex)
            {
                await Core.Bot.LogForm(ex.Message);
            }
        }

        private void TokenForm_Load(object sender, EventArgs e)
        {
            Icon = Program.ZenoForm.Icon;
        }
    }
}
