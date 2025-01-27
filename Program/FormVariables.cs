using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wind_up_Zeno
{
    internal class FormVariables
    {
    }

    public partial class FormMain
    {
        //new line
        private readonly string NL = Environment.NewLine;

        //check box behabior
        private bool IsUser = true;

        //toggle console size
        private bool ConsoleFull = true;
        const int DIF = 217;

        //log timestamp
        private static string Timestamp { get => DateTime.Now.ToString("HH:mm:ss.fff"); }

        // FormClosing behabior
        public bool AbleToClose = false;


    }


    public partial class UserForm : Form
    {
        //params
        public SocketGuildUser User { get; set; }
        //new line
        string NL => Environment.NewLine;
    }
}
