using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wind_up_Zeno
{
    public partial class Zeno
    {
        public async void CreateShortcut()
        {
            //const int WINDOWSTYLE_NORMAL = 1;
            //const int WINDOWSTYLE_MIN = 7;

            string GetFName = $"Zeno {Application.ProductVersion}.lnk";
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            string fullpath = System.IO.Path.Combine(path, GetFName);
            bool res = await HasUpdated(fullpath, path);

            if (res)
            {
#if !DEBUG
                const int WINDOWSTYLE_MAX = 3;

                var files = Directory.GetFiles(path);
                foreach (var item in files)
                {
                    if (item.StartsWith("Zeno"))
                    {
                        File.Delete(item);
                        string old = System.IO.Path.GetFileName(item);
                        await LogDebug($"File {old} has been removed.");
                    }
                }


                dynamic shell = Activator.CreateInstance(Type.GetTypeFromProgID("WScript.Shell"));
                dynamic shortcut = shell.CreateShortcut(fullpath);
                shortcut.TargetPath = Process.GetCurrentProcess().MainModule.FileName;
                shortcut.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
                shortcut.WindowStyle = WINDOWSTYLE_MAX;
                shortcut.Description = "Bot Zeno";
                shortcut.Save();
#else
                await LogDebug("CreateShortcut ignored because DUBUG");
#endif
            }
        }

        static async Task<bool> HasUpdated(string fullpath, string folderpath)
        {
            if (File.Exists(fullpath))
            {
                await Log($"Zeno Version: {Application.ProductVersion}");
                return false;
            }
            else
            {
                await Log($"An update has detected => Version: {Application.ProductVersion}");
                await LogDebug($"New shortcurt was created: {fullpath}");
                var files = Directory.GetFiles(folderpath);
                foreach (var item in files)
                {
                    if (item.Contains("Zeno")) File.Delete(item);
                    await LogExtra($"File: {item} delted.");
                }

                return true;
            }
        }
    }
}
