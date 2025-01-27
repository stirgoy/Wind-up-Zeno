namespace Wind_up_Zeno
{
    public partial class Zeno
    {
        public Discord.ConnectionState IsOnline()
        {
            Discord.ConnectionState r = Discord.ConnectionState.Disconnected;
            if (Bot_Zeno != null)
            {
                return Bot_Zeno.ConnectionState;
            }
            return r;
        }
    }
}
