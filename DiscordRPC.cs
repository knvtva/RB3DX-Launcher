using System;
using System.IO;
using System.Threading;
using Microsoft.VisualBasic.Logging;
using RB3DX_Launcher;

namespace DiscordRPC
{
    public class DiscordRPC
    {
        private static DiscordRpcClient client;
        private static FileSystemWatcher watcher;
        private static object txt_State;
        private static object JSON_FILE;
        private static string jsonData;
        
        

        public static void StartRPC()
        {
            Logger.LogInfo("Starting DiscordRPC...");

            client = new DiscordRpcClient("1125571051607298190",
                client: new IO.ManagedNamedPipeClient(),
                autoEvents: true
            );

            client.OnReady += (sender, msg) =>
            {
                Logger.LogInfo($"Connected to discord with user {msg.User.Username}");
            };

            try {
                string configPath = "RB3DX.config";
                string[] configLines = System.IO.File.ReadAllLines(configPath);
                string devHDD0 = configLines[1];

                JSON_FILE = devHDD0 + "/game/BLUS30463/USRDIR/";
            }
            catch (Exception e)
            {
                Logger.LogError(e.Message);
            }

            Logger.LogDebug(JSON_FILE);

            client.Initialize();
            InitializeWatcher();
            updateRPC();
        }

        private static void InitializeWatcher()
        {
            try {
                watcher = new FileSystemWatcher();
                watcher.Path = (string)JSON_FILE;
                watcher.Filter = "discordrp.json";
                watcher.NotifyFilter = NotifyFilters.LastWrite;
                watcher.Changed += OnFileChanged;
                watcher.EnableRaisingEvents = true;
            }
            catch (Exception e)
            {
                Logger.LogError(e.Message);
            }
        }

        private static void OnFileChanged(object source, FileSystemEventArgs e)
        {
            try {
                updateRPC();
            }
            catch (Exception) 
            {
                // Pass, Allows the launcher to update the discordRPC
            }
        }

        public static void updateRPC()
        {
            try {
                jsonData = File.ReadAllText((string)JSON_FILE + "/discordrp.json");

                string parsedInput = jsonData.Replace("\\q", "\"");
                parsedInput = parsedInput.Replace("'", "'");
                parsedInput = parsedInput.Substring(1, parsedInput.Length - 4);

                Logger.LogDebug(parsedInput);
            }
            catch (Exception e)
            {
                Logger.LogError(e.Message);
            }
            Logger.LogDebug($"isGameStarted: {Form1.isGameStarted}");

            if (Form1.isGameStarted == true)
            {
                //
            }
            else
            {
                txt_State = "In Launcher";
            }

            //client.Initialize();
            client.SetPresence(new RichPresence()
            {
                State = $"{txt_State}",
                Buttons = new Button[]
                {
                    new Button() { Label = "🔨 GitHub", Url = "https://github.com/hmxmilohax/rock-band-3-deluxe"},
                    new Button() { Label = "🎸 Download", Url = "https://rb3dx.neocities.org" }
                },
                Assets = new Assets()
                {
                    LargeImageKey = "banner",
                    LargeImageText = "Rock Band 3 Deluxe RPCS3",
                    SmallImageKey = "vocals"
                }
            });
        }
    }
}
