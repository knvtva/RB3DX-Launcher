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
                ArchivePreviousLog();
                Logger.LogInfo("Checking for the latest update...");
                ApplicationConfiguration.Initialize();
                Application.Run(new Form1());
            }
            catch (Exception) 
            {
                ; // I had a logging msg here, but it spams the log so I removed it :) (Ash)
            }
        }

        static void ArchivePreviousLog()
        {
            try
            {
                if (File.Exists(Logger.logFilePath))
                {
                    string archivedLogName = $"log_{DateTime.Now:yyyyMMdd_HHmm}.txt";
                    File.Move(Logger.logFilePath, archivedLogName);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error archiving previous log: {ex.Message}");
            }
        }
    }
}