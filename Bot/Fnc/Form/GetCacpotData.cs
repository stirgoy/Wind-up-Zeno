using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wind_up_Zeno
{
    public partial class Zeno
    {
        public List<string> GetCacpotData()
        {
            List<string> r = new List<string>() { Config.LastCacpot, Config.CacpotIds.Count.ToString() };
            return r;
        }
    }
}
