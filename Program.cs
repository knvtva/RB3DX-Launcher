namespace RB3DX_Launcher
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            Logger.LogInfo("Checking for the latest update...");

            // (TODO:Ash) Finish off writing the launcher version checker + Deluxe updater.
        }
    }
}
