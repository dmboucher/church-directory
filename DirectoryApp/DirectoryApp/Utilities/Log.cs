using System;
using System.IO;

namespace DirectoryApp
{
    public class Log
    {
        public void GlobalHandler(object sender, UnhandledExceptionEventArgs args)
        {
            Exception ex = (Exception)args.ExceptionObject;
            using (StreamWriter writer = File.AppendText($"{AppDomain.CurrentDomain.BaseDirectory}\\log_{ DateTime.Now:yyyyMMdd}.txt"))
            {
                WriteLog(ex.Message, writer);
            }
        }


        public void WriteLog(string logMessage, TextWriter writer)
        {
            writer.Write("\r\nError: ");
            writer.WriteLine($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}:");
            writer.WriteLine($"  :{logMessage}");
            writer.WriteLine("-------------------------------");
        }
    }
}
