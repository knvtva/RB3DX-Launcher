using System;
using System.Diagnostics;
using System.Timers;

class ProcessWatcher
{
    public static string processName = "rpcs3";
    public static bool isGameRunning = false;

    public static void Start()
    {
        System.Timers.Timer timer = new System.Timers.Timer();
        timer.Elapsed += (sender, e) => CheckProcessState();
        timer.Interval = 1000;
        timer.AutoReset = true;
        timer.Start();
    }

    static void CheckProcessState()
    {
        bool currentProcessState = IsProcessRunning(processName);

        if (currentProcessState == true) 
        {
            isGameRunning = true;
        }
        else
        {
            isGameRunning = false;
            try {
                File.WriteAllText(DiscordRPC.DiscordRPC.JSON_FILE, string.Empty);
            }
            catch
            {
                ;
            }


        }
    }

    static bool IsProcessRunning(string processName)
    {
        Process[] processes = Process.GetProcessesByName(processName);
        return processes.Length > 0;
    }
}
