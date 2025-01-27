using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wind_up_Zeno
{
    public partial class Zeno
    {
        private static Task Config_Save()
        {
            string js = JsonConvert.SerializeObject(Config, Formatting.Indented);
            File.WriteAllText($"{Path}\\{Json_file}", js);
            return Task.CompletedTask;
        }
    }
}
