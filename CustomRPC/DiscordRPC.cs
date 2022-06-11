using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiscordRPC;
using DiscordRPC.Logging;

namespace CustomRPC
{

    internal class DiscordRPC
    {
        private static DiscordRpcClient rpc;

        public static void startRPC(string clientid)
        {
            rpc = new DiscordRpcClient(clientid);

            rpc.Logger = new ConsoleLogger() { Level = LogLevel.Warning };

            rpc.OnReady += (sender, e) =>
            {
                Console.WriteLine("Ready lol: ", e.User.Username);
            };

            rpc.OnPresenceUpdate += (sender, e) =>
            {
                Console.WriteLine("Received Update! {0}", e.Presence);
            };

            rpc.Initialize();
        }

        public static void update(string firstLine, string secondLine, bool time)
        {
            rpc.SetPresence(new RichPresence()
            {
                Details = firstLine,
                State = secondLine,
                Assets = new Assets()
                {
                    LargeImageKey = "large",
                    LargeImageText = "balls",
                }
            });
        }

        public static void stop()
        {
            rpc.Dispose();
        }
    }
}
