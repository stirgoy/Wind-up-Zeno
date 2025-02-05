using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wind_up_Zeno
{
    internal class ZenoInstance { }

    public partial class FormMain
    {
        private void ZenoInstance()
        {

            Core.Bot = new Zeno
            {
                //TxtLog delegate
                OnLog = (message) =>
                {
                    if (!IsHandleCreated || Disposing || IsDisposed) return;

                    BeginInvoke(new Action(() =>
                    {
                        if (Disposing || IsDisposed) return;

                        try
                        {

                            if (TxtLog != null)
                            {
                                TxtLog.AppendText($"{Timestamp} · {message} \r\n");

                                string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Zeno";
                                if (!Directory.Exists($"{path}\\Logs")) { Directory.CreateDirectory($"{path}\\Logs"); }
                                string f = DateTime.Now.ToString("ddMM");
                                File.AppendAllText($"{path}\\Logs\\{f}", $"{message}{NL}");

                            }
                        }
                        catch (Exception)
                        {

                        }
                    }));
                }
            };
        }
    }
}
