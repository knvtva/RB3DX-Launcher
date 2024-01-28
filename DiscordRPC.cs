using System;

namespace DiscordRPC
{
    public class DiscordRPC
    {
        public static void startRPC() {
            Logger.LogInfo("Starting DiscordRPC...");

            var client = new DiscordRpcClient("1125571051607298190");

            client.OnReady += (sender, msg) =>
            {
                Logger.LogInfo($"Connected to discord with user {msg.User.Username}");
            };

            client.Initialize();

            client.SetPresence(new RichPresence()
            {
                //Details = "Rock Band 3 Deluxe",
                State = "In Launcher",
                Buttons = new Button[]
                {
                    new Button() { Label = "🎸 Download", Url = "https://rb3dx.neocities.org" }
                }
            });

            Console.ReadKey();

            client.Dispose();
        }
    }
}