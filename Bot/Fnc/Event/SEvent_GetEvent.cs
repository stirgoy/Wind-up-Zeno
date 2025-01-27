using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wind_up_Zeno
{
    public partial class Zeno
    {
        /********************
                GetEvent
        *////////////////////
        private static string[] SEvent_GetEvent(string event_id)
        {
            foreach (string[] item in Config.Events_Noticed)
            {
                if (event_id == item[0])
                {
                    return item;
                }
            }

            return new string[0];
        }
    }
}
