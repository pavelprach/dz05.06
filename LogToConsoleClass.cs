using System;
using static System.Console;
namespace LogToConsole2
{
    public class LogToConsoleClass
    {
        public static void Info(string message)
        {
            var dateTime = DateTime.Now;
            var msg = $"[{dateTime.ToString("G")}] INFO : {message}"; // [dd.mm.yyyy hh:mm:ss] INFO : message
            ForegroundColor = ConsoleColor.Blue;
            WriteLine(msg);
            ResetColor();
        }
        public static void Error(string message)
        {
            var dateTime = DateTime.Now;
            var msg = $"[{dateTime.ToString("G")}] ERROR : {message}"; // [dd.mm.yyyy hh:mm:ss] ERROR : message
            ForegroundColor = ConsoleColor.Red;
            WriteLine(msg);
            ResetColor();
        }
        public static void Successfully(string message)
        {
            var dateTime = DateTime.Now;
            var msg = $"[{dateTime.ToString("G")}] SUCCESS : {message}"; // [dd.mm.yyyy hh:mm:ss] SUCCESS : message
            ForegroundColor = ConsoleColor.Green;
            WriteLine(msg);
            ResetColor();
        }
    }
}
