using System.Threading.Tasks;

namespace Terminal_WinForms_App.Services {
    
    public enum LogType {
        Info = 0,
        Warning = 1,
        Error = 2,
        Repaired = 3
    }
    public class LoggingService {
        private BackEndRequestService backEndRequestService;
        public LoggingService(BackEndRequestService backEndRequestService) {
            this.backEndRequestService = backEndRequestService;
        }
        
        public async Task LogError(string message) {
            await backEndRequestService.LogWriteRequest(message, LogType.Error);
        }

        public async Task LogInfo(string message) {
            await backEndRequestService.LogWriteRequest(message, LogType.Info);
        }

        public async Task LogWarning(string message) {
            await backEndRequestService.LogWriteRequest(message, LogType.Warning);
        }
        public async Task Repaired() {
            await backEndRequestService.LogRepaired();
        }
    }
}
