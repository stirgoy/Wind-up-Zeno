using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wind_up_Zeno
{
    public partial class Zeno
    {
        public Dictionary<string, string> GetEmotes()
        {
            Dictionary<string, string> r = new Dictionary<string, string>();

            Type type = typeof(Emote.Bot);
            foreach (var item in type.GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static))
            {
                r.Add(item.Name, item.GetValue(null).ToString());
            }

            return r;
        }
    }
}
