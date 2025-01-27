using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Wind_up_Zeno.XIVLN;

namespace Wind_up_Zeno
{
    public partial class Zeno
    {
        /********************
            RemoveTalkChannel
        *////////////////////
        private void RemoveTalkChannel(String channel)
        {
            //Remove allowed talk channel
            StringCollection channels = Config.Channels.TalkChannel;
            StringCollection new_channels = new StringCollection();
            foreach (var item in channels)
            {
                if (item != channel)
                {
                    new_channels.Add(item);
                }
            }

            Config.Channels.TalkChannel = new_channels;
            Config_Save();
        }
    }
}
