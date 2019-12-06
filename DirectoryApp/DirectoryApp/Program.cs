using System;
using System.Windows.Forms;

namespace DirectoryApp
{
    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var Log = new Log();
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(Log.GlobalHandler);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}
