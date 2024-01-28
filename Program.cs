using Microsoft.VisualBasic.Logging;

namespace RB3DX_Launcher
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            try {
                DiscordRPC.DiscordRPC.StartRPC();
                Logger.LogInfo("Checking for the latest update...");
                ApplicationConfiguration.Initialize();
                Application.Run(new Form1());
            }
            catch (Exception) 
            {
                // Pass, Allows the launcher to boot
            }

            // (TODO:Ash) Finish off writing the launcher version checker + Deluxe updater.
        }
    }
}