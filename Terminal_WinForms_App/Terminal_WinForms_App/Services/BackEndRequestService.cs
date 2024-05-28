using System.Threading;
using System.Threading.Tasks;

namespace Terminal_WinForms_App.Services {
    public class BackEndRequestService {
        private string baseUri;
        private HttpService httpService;
        public BackEndRequestService(string baseUri) {
            this.baseUri = baseUri;
            this.httpService = new HttpService();
        }

        public bool CheckPhoneNumberRequest(string phoneNumber) {
            // API call to backEnd to check the phone number for elligibility
            Thread.Sleep(3000);
            return true;
        }

        public void MakePaymentRequest(string phoneNumber, int amount) {
            Thread.Sleep(2000);
        }

        public void CassetteRemovedAndCleanedRequest() { 
        
        }

        public void LogWriteRequest(string message, int status) {

        }
    }
}
