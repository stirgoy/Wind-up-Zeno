using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wind_up_Zeno
{
    public partial class SchedulesForm : Form
    {
        public SchedulesForm()
        {
            InitializeComponent();
        }


        private void SchedulesForm_Shown(object sender, EventArgs e)
        {
            var schedules = Core.Bot.GetSchedules();

            TxtWeekly.Text = schedules[0].ToString();
            TxtDaylie.Text = schedules[1].ToString();
            TxtGC.Text = schedules[2].ToString();
            TxtCacpot.Text = schedules[3].ToString();
            TxtLoopCacpot.Text = Core.Bot.GetCacpotDelay;

            ChkXIVLN.Checked = XIVLN.Config.Enabled;
            ChkBadWordsBlackList.Checked = Core.Bot.GetBadWordsBlackList;
            ChkRunBot.Checked = Core.Bot.GetRunBot;
            ChkUpdateSlashCommands.Checked = Core.Bot.GetUpdateSlashCommands;
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox ctxt)
            {
                //common

                string[] WhiteList = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };

                if (!WhiteList.Contains(ctxt.Text.Last().ToString()))
                {
                    List<char> ctext = ctxt.Text.ToList();
                    ctext.Remove(ctext.Last());
                    ctxt.Text = string.Join("", ctext);
                }

                if (ctxt.Name == "TxtLoopCacpot") return;

                if (ctxt.Text.Length > 2)
                {
                    List<char> ctext = ctxt.Text.ToList();
                    ctext.Remove(ctext.Last());
                    ctxt.Text = string.Join("", ctext);
                }

            }
        }

        private async void SchedulesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            int w = int.Parse(TxtWeekly.Text);
            int d = int.Parse(TxtDaylie.Text);
            int g = int.Parse(TxtGC.Text);
            int c = int.Parse(TxtCacpot.Text);
            int cd = int.Parse(TxtLoopCacpot.Text);

            int[] ss = new int[] { w, d, g, c };
            Core.Bot.SetSchedules(ss);
            Core.Bot.SetCacpotDelay(cd);

            XIVLN.Config.Enabled = ChkXIVLN.Checked;
            Core.Bot.SetBadWordsBlackList(ChkBadWordsBlackList.Checked);
            Core.Bot.SetRunBot(ChkRunBot.Checked);
            Core.Bot.SetUpdateSlashCommands(ChkUpdateSlashCommands.Checked);


            await Core.Bot.ConfigSave();
        }
    }



    public partial class Zeno
    {
        public int[] GetSchedules() => Config.FF_Schedules;
        public string GetCacpotDelay => Config.CacpotLoopDelay.ToString();

        public bool GetBadWordsBlackList => Config.BadWordsBlackList;
        public bool GetRunBot => Config.RunBot;
        public bool GetUpdateSlashCommands => Config.UpdateSlashCommands;


        public void SetSchedules(int[] schedules) => Config.FF_Schedules = schedules;
        public void SetCacpotDelay(int delay) => Config.CacpotLoopDelay = delay; 

        public void SetBadWordsBlackList(bool v) => Config.BadWordsBlackList = v;
        public void SetRunBot(bool v) => Config.RunBot = v;
        public void SetUpdateSlashCommands(bool v) => Config.UpdateSlashCommands = v;

        public async Task ConfigSave() => await Config_Save();


    }





}
