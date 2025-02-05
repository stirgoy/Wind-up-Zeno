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
            borrar_msg
        *//////////////////// for delete bot messages over time
        private static void BorrarMsg(dynamic botMessage, int tiempo = 8)
        {
            _ = Task.Run(async () =>
            {
                await Task.Delay(tiempo * 1000);
                await LogExtra($"Deleting message: {botMessage.Id}");
                try { await botMessage.DeleteAsync(); } catch (Exception ex) { await LogError(ex.Message); }
            });
        }
    }
}
