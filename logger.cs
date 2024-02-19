using System;
using System.Diagnostics;
using System.IO;

class Logger
{
    public static bool Debug = true;
    public static string logFilePath = "RB3DX.log";

    public static void LogInfo(object message)
    {
        string formattedMessage = $"[RB3DX-Launcher:INFO] {message}";
        Log(formattedMessage);
    }
    

    public static void LogError(object message)
    {
        string formattedMessage = $"[RB3DX-Launcher:ERROR] {message}";
        Log(formattedMessage);
    }
    public static void LogDebug(object message)
    {
        if (Debug == true)
        {
            string formattedMessage = $"[RB3DX-Launcher:DEBUG] {message}";
            Log(formattedMessage);
        }
    }

    private static void Log(string message)
    {
        try
        {
            using (StreamWriter writer = File.AppendText(logFilePath))
            {
                writer.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}");
            }
        }
        catch (Exception ex)
        {
            // (TODO) Handle log file write errors.
            Console.WriteLine($"Error writing to log file: {ex.Message}");
        }
    }
}

