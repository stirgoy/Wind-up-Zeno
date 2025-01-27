using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wind_up_Zeno
{
    public partial class Zeno
    {
        public bool GetAutostart()
        {
            return Config.AutoStart;
        }

        public void ToggleAutostart()
        {
            Config.AutoStart = !Config.AutoStart;
            Config_Save();
        }



    }
}
