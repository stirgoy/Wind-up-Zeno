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
                UnixTime
        *//////////////////// returns cord timestamp
        private static string UnixTime(DateTime date, string mode = "R")
        {
            long unixTimestamp = new DateTimeOffset(date).ToUnixTimeSeconds();
            return $"<t:{unixTimestamp}:{mode}>";

        }
    }
}
