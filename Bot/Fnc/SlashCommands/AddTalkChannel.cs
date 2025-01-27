using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wind_up_Zeno
{
    public partial class Zeno
    {
        /********************
            AddTalkChannel
        *////////////////////
        private async void AddTalkChannel(String channel)
        {
            //Add allowed talk channel
            StringCollection channels = Config.Channels.TalkChannel;
            if (channels == null) channels = new StringCollection();
            channels.Add(channel);
            Config.Channels.TalkChannel = channels;
            await Config_Save();
        }
    }
}
