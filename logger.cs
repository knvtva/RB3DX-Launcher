using System;
using System.IO;

class Logger
{
    private static string logFilePath = "RB3DX.log";

    public static void LogInfo(string message)
    {
        string formattedMessage = $"[RB3DX-Launcher:INFO] {message}";
        Log(formattedMessage);
    }

    public static void LogError(string message)
    {
        string formattedMessage = $"[RB3DX-Launcher:ERROR] {message}";
        Log(formattedMessage);
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

