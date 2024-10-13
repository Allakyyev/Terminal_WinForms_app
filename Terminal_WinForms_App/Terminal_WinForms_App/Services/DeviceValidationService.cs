using System.Management;
namespace Terminal_WinForms_App.Services {
    public static class DeviceValidationService {
        public static string GetProcessorId() {
            string processorId = string.Empty;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select ProcessorId from Win32_Processor");
            foreach(ManagementObject obj in searcher.Get()) {
                processorId = obj["ProcessorId"].ToString();
                break;
            }
            return processorId;
        }

        public static string GetMotherboardSerialNumber() {
            string serialNumber = string.Empty;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_BaseBoard");
            foreach(ManagementObject obj in searcher.Get()) {
                serialNumber = obj["SerialNumber"].ToString();
                break;
            }
            return serialNumber;
        }
    }
}
