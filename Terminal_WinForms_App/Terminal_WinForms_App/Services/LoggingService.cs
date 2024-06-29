namespace Terminal_WinForms_App.Services {
    public enum LogStatus {
        Info = 1,
        Warning = 2,
        Error = 3,
    }
    public class LoggingService {
        private BackEndRequestService backEndRequestService;
        public LoggingService(BackEndRequestService backEndRequestService) {
            this.backEndRequestService = backEndRequestService;
        }

        public void LogError(string message) {
            backEndRequestService.LogWriteRequest(message, 3);
        }

        public void LogInfo(string message) {
            backEndRequestService.LogWriteRequest(message, 1);
        }

        public void LogWarning(string message) {
            backEndRequestService.LogWriteRequest(message, 2);
        }
    }
}
