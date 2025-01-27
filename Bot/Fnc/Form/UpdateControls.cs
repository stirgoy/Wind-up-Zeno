using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wind_up_Zeno
{
    public partial class Zeno
    {
        public static void UpdateControls()
        {
            Program.ZenoForm.LstUsers.BeginInvoke(new Action(() =>
            {
                Program.ZenoForm.AppUpdate();
            }));

        }
    }
}
