using System.Collections.Specialized;
using WK.Libraries.SharpClipboardNS;

namespace ExplorerPasteHelper
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
            var mainForm = new MainForm();
            Application.Run(mainForm);
        }
    }
}