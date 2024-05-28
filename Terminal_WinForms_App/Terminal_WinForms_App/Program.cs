using System;
using System.Configuration;
using System.Windows.Forms;
using Terminal_WinForms_App.Services;

namespace Terminal_WinForms_App {
    internal static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            string terminalId = ConfigurationManager.AppSettings["TerminalId"];
            string terminalKey = ConfigurationManager.AppSettings["TerminalKey"];
            string baseUri = ConfigurationManager.AppSettings["BackendBaseUri"];
            string comPort = ConfigurationManager.AppSettings["ComPort"];            
            
        Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(terminalId, terminalKey, baseUri, comPort));
        }
    }
}
