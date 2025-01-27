using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wind_up_Zeno
{
    public class Run { }
    public partial class FormMain
    {
        private void Run(string file, string arg)
        {
            Process p = new Process();
            p.StartInfo.FileName = file;
            p.StartInfo.Arguments = arg;
            p.Start();
            p.Dispose();

        }
    }
}
