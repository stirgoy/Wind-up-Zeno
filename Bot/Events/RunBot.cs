using Discord;
using Discord.WebSocket;
using System;
using System.Threading.Tasks;

namespace Wind_up_Zeno
{
    public partial class Zeno
    {

        public async Task RunBot()
        {
            if (!Config.RunBot)
            {
                await LogError("Bot connection is dissabled: RunBot => false");
                return;
            }

            await Log("Checking login Token...");
#if DEBUG
            string token = Environment.GetEnvironmentVariable("ZenosT", EnvironmentVariableTarget.User);
#else
            string token = Environment.GetEnvironmentVariable("WUZenosT", EnvironmentVariableTarget.User);      
#endif

            if (token == null)
            {
                await Log("Token not found, add token bot and try start bot again.");
                UpdateControls();
                TokenForm tf = new TokenForm();
                tf.ShowDialog();
                return;
            }

            await Log("Setting up bot...");
            
            if (Bot_Zeno != null)
            {
                Bot_Zeno.Dispose();
                Bot_Zeno = null;
            }
            
            await Log("Loading Bad words...");
            await WBL_Load();

            Bot_Zeno = new DiscordSocketClient(CordSocketConfig);

            //core
            Bot_Zeno.Log += LogAsync;
            Bot_Zeno.MessageReceived += MessageReceivedAsync;
            Bot_Zeno.Ready += ReadyAsync;
            Bot_Zeno.SlashCommandExecuted += SlashCommandHandlerAsync;
            Bot_Zeno.Disconnected += BotDisconnected;
            Bot_Zeno.Connected+= BotConnected;
            // users
            Bot_Zeno.UserJoined += Kuru_UserJoined;
            Bot_Zeno.UserLeft += Kuru_UserLeft;
            //scheduled events
            Bot_Zeno.GuildScheduledEventUserAdd += SEvent_UserAdd;
            Bot_Zeno.GuildScheduledEventUserRemove += SEvent_UserRemove;
            Bot_Zeno.GuildScheduledEventCancelled += SEvent_Canceled;
            Bot_Zeno.GuildScheduledEventCompleted += SEvent_Completed;
            Bot_Zeno.GuildScheduledEventCreated += SEvent_Created;
            Bot_Zeno.GuildScheduledEventStarted += SEvent_Started;

            //connect
            await Log("Attempt to login...");

            
            if (!string.IsNullOrEmpty(token))
            {
                await Bot_Zeno.LoginAsync(TokenType.Bot, token);            
                await Bot_Zeno.StartAsync();
            }
            else
            {
                await LogError($"Token is not valid: {token}");
            }


        }
                
    }

}
