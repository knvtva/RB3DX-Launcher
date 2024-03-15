using System;
using System.IO;
using System.Threading;
using System.Text.Json;
using Microsoft.VisualBasic.Logging;
using RB3DX_Launcher;

namespace DiscordRPC
{
    public class DiscordRPC
    {
        private static DiscordRpcClient client;
        private static FileSystemWatcher watcher;
        private static object txt_State;
        public static string JSON_FILE;
        private static string RB3_PATH;
        private static string jsonData;
        private static string? gameMode = null;
        private static string? ScreenCategory = null;
        private static string? CurrentScreen = null;
        private static string? isOnline = null;
        private static string? Loaded_Song = null;
        private static object? SelectedInstruments = null;
        private static string? active_instrument_text = null;
        private static string active_instrument_small_image;
        private static string active_instrument_small_text;
        private static int? active_instrument_count = null;
        private static JsonElement AllInstruments { get; set; }

        private static string? instrument_name = null;
        private static string? instrument_small_text_name = null;
        private static string? instrument_difficulty = null;
        private static string filePath;

        private static readonly Dictionary<string, string> gameModeMapping = new Dictionary<string, string>
        {
            { "defaults", "In the Menus" },
            { "audition", "Audition Mode" },
            { "qp_coop", "Quickplay" },
            { "party_shuffle", "Party Shuffle" },
            { "tour", "Tour" },
            { "trainer", "Instrument Training" },
            { "practice", "Practice" },
            { "career", "Road Challenges" },
            { "autoplay", "Autoplay" },
            { "jukebox", "Jukebox" }
        };

        private static readonly Dictionary<string, string> SimplifyInstrumentName = new Dictionary<string, string>
        {
            { "GUITAR", "Guitar" },
            { "REAL_GUITAR", "Pro Guitar" },
            { "KEYS", "Keys" },
            { "DRUMS", "Drums" },
            { "REAL_KEYS", "Pro Keys" },
            { "REAL_BASS", "Pro Bass" },
            { "BASS", "Bass" },
            { "VOCALS", "Vocals" },
        };

        private static readonly Dictionary<string, string> CleanDifficulty = new Dictionary<string, string>
        {
            { "0", "Warmup" },
            { "1", "Apprentice" },
            { "2", "Solid" },
            { "3", "Moderate" },
            { "4", "Challenging" },
            { "5", "Nightmare" },
            { "6", "Impossible" },
        };

        private static readonly Dictionary<string, string> MapInstrumentToSmallImage = new Dictionary<string, string>
        {
            { "GUITAR", "guitar" },
            { "REAL_GUITAR", "real_guitar" },
            { "KEYS", "keys" },
            { "DRUMS", "drums" },
            { "REAL_KEYS", "real_keys" },
            { "REAL_BASS", "real_bass" },
            { "BASS", "bass" },
            { "VOCALS", "vocals" },
        };

        public static int? Active_instrument_count { get => active_instrument_count; set => active_instrument_count = value; }


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

                RB3_PATH = devHDD0 + "/game/BLUS30463/USRDIR/";
                JSON_FILE = RB3_PATH + "discordrp.json";
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
                watcher.Path = RB3_PATH;
                watcher.Filter = "discordrp.json";
                watcher.NotifyFilter = NotifyFilters.LastWrite;
                watcher.Changed += OnFileChanged;
                watcher.EnableRaisingEvents = true;
            }
            catch (Exception e)
            {
                ;
            }
        }

        private static void OnFileChanged(object source, FileSystemEventArgs e)
        {
            try {
                updateRPC();
            }
            catch (Exception) 
            {
                ;
            }
        }

        public static void updateRPC()
        {
            try
            {
                if (ProcessWatcher.isGameRunning == true)
                {
                    bool fileAccessed = false;
                    int retries = 3;
                    while (!fileAccessed && retries > 0)
                    {
                        try
                        {
                            string filePath = JSON_FILE;
                            string jsonData = File.ReadAllText(filePath);

                            string parsedInput = jsonData.Replace("\\q", "\"");
                            parsedInput = parsedInput.Replace("'", "'");
                            parsedInput = parsedInput.Substring(1, parsedInput.Length - 4);

                            JsonDocument doc = JsonDocument.Parse(parsedInput);

                            JsonElement root = doc.RootElement;

                            Loaded_Song = "No song loaded";
                            SelectedInstruments = "";
                            active_instrument_text = "";
                            active_instrument_count = 0;
                            instrument_name = "";
                            instrument_small_text_name = "";
                            instrument_difficulty = "";
                            active_instrument_small_text = "";
                            active_instrument_small_image = "";

                            try
                            {
                                gameMode = root.GetProperty("Game mode").GetString();
                                ScreenCategory = root.GetProperty("Screen Category").GetString();
                                CurrentScreen = root.GetProperty("Current Screen").GetString();
                                isOnline = root.GetProperty("Online").GetString() ?? "Not Found";
                                Loaded_Song = root.GetProperty("Loaded Song").GetString();
                                SelectedInstruments = root.GetProperty("SelectedInstruments");
                            }
                            catch (Exception e)
                            {
                                ;//Logger.LogError(e.Message); This will spam log. So It's best off if we leave it out for now
                            }

                            if (gameModeMapping.ContainsKey(gameMode))
                            {
                                gameMode = gameModeMapping[gameMode];
                            }

                            if (SelectedInstruments is JsonElement instrumentsArray)
                            {
                                AllInstruments = instrumentsArray;
                                active_instrument_count = instrumentsArray.EnumerateArray().Count(instrument => instrument.GetProperty("active").GetBoolean());

                                active_instrument_text = "";
                                if (active_instrument_count > 1)
                                {
                                    active_instrument_text = $"{active_instrument_count} player band";
                                }
                                else if (active_instrument_count == 1)
                                {
                                    active_instrument_text = "1 player band";
                                }
                            }

                            try
                            {
                                if (active_instrument_count > 1)
                                {
                                    active_instrument_text = $"{active_instrument_count} Player";
                                    active_instrument_small_image = "default_small_image_name";
                                }
                                else
                                {
                                    foreach (var instrument in AllInstruments.EnumerateArray())
                                    {
                                        if (instrument.GetProperty("active").GetBoolean() && Loaded_Song != "No song loaded")
                                        {
                                            instrument_name = instrument.GetProperty("instrument").GetString();
                                            instrument_small_text_name = instrument.GetProperty("instrument").GetString();
                                            instrument_difficulty = instrument.GetProperty("difficulty").GetString();

                                            instrument_name = SimplifyInstrumentName[instrument_name];
                                            instrument_difficulty = CleanDifficulty[instrument_difficulty];

                                            active_instrument_text = "Solo";
                                            active_instrument_small_text = $"{instrument_name}, {instrument_difficulty}";
                                            active_instrument_small_image = MapInstrumentToSmallImage[instrument_small_text_name];
                                            break;
                                        }
                                    }
                                    if (string.IsNullOrEmpty(active_instrument_text))
                                    {
                                        active_instrument_text = "";
                                    }
                                }

                                if (isOnline == "true")
                                {
                                    gameMode = "Online " + gameMode;
                                }
                            }
                            catch {;}
                        
                            try
                            {
                                client.SetPresence(new RichPresence()
                                {
                                    Details = $"{active_instrument_text} {gameMode}",
                                    State = $"{Loaded_Song}",
                                    Buttons = new Button[]
                                    {
                                        new Button() { Label = "🖥️ GitHub", Url = "https://github.com/hmxmilohax/rock-band-3-deluxe"},
                                        new Button() { Label = "⬇️ Download", Url = "https://rb3dx.neocities.org" }
                                    },
                                    Assets = new Assets()
                                    {
                                        LargeImageKey = "banner",
                                        LargeImageText = "Rock Band 3 Deluxe RPCS3",
                                        SmallImageKey = active_instrument_small_image,
                                        SmallImageText = active_instrument_small_text ?? null,
                                    }
                                });
                            }
                            catch (Exception e)
                            {
                                Logger.LogError(e.Message);
                            }

                            // Set fileAccessed to true if file access is successful
                            fileAccessed = true;
                        }
                        catch (IOException ex)
                        {
                            Logger.LogError($"Error accessing file: {ex.Message}");
                            retries--;
                            Thread.Sleep(1000); // Wait for 1 second before retrying
                        }
                    }

                    // If file was not accessed after retries, log an error
                    if (!fileAccessed)
                    {
                        Logger.LogError("Failed to access file after retries.");
                        return;
                    }
                }
                else
                {
                    txt_State = "In Launcher";
                    client.SetPresence(new RichPresence()
                    {
                        State = $"{txt_State}",
                        Buttons = new Button[]
                        {
                            new Button() { Label = "🖥️ GitHub", Url = "https://github.com/hmxmilohax/rock-band-3-deluxe"},
                            new Button() { Label = "⬇️ Download", Url = "https://rb3dx.neocities.org" }
                        },
                        Assets = new Assets()
                        {
                            LargeImageKey = "banner",
                            LargeImageText = "Rock Band 3 Deluxe RPCS3",
                        }
                    });
                }
            }
            catch (Exception e)
            {
                Logger.LogError(e.Message);
            }
        }
    }
}
