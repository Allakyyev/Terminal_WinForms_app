﻿using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Terminal_WinForms_App.Services;

namespace Terminal_WinForms_App {
    public class Config {
        public string TerminalId { get; set; }
        public string TerminalKey { get; set; }
        public string BackendBaseUri { get; set; }
        public string ComPort { get; set; }
    }
    internal static class Program {
        private const string ConfigFilePath = "config.json";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static async Task Main() {
            //string terminalId = ConfigurationManager.AppSettings["TerminalId"];
            //string terminalKey = ConfigurationManager.AppSettings["TerminalKey"];
            //string baseUri = ConfigurationManager.AppSettings["BackendBaseUri"];
            //string comPort = ConfigurationManager.AppSettings["ComPort"];
            if(!File.Exists(ConfigFilePath)) {
                return;
            }
            var json = File.ReadAllText(ConfigFilePath);
            var config = JsonConvert.DeserializeObject<Config>(json);
            var backEndRequestService = new BackEndRequestService(config.BackendBaseUri, config.TerminalId, config.TerminalKey);
            var result = await backEndRequestService.RegisterTerminalResuest(new RegisterTerminalRequest() {
                TerminalId = config.TerminalId,
                MotherboardId = DeviceValidationService.GetMotherboardSerialNumber(),
                CpuId = DeviceValidationService.GetProcessorId()
            });
            if(!result.Success) {
                throw new Exception("Some thing went wrong");                
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(config.TerminalId, config.TerminalKey, config.BackendBaseUri, config.ComPort));
        }
    }
}
