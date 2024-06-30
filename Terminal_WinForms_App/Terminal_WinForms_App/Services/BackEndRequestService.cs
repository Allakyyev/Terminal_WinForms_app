using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Terminal_WinForms_App.Services {
    public class BackEndRequestService {
        string baseUri;
        string terminalId;
        string terminalIdEncrypted;
        string terminalPassword;
        LoggingService logger;
        readonly HttpClient _httpClient;        
        public BackEndRequestService(string baseUri, string terminalId, string terminalPassword) {
            this.baseUri = baseUri;
            this._httpClient = new HttpClient();
            this.terminalId = terminalId;
            this.terminalIdEncrypted = AesEncryptionHelper.EncryptString(terminalId);
            this.terminalPassword = terminalPassword;
            logger = new LoggingService(this);
        }


        public async Task<string[]> GetServicesAsync() {
            var response = await _httpClient.GetAsync($"{this.baseUri}/get-services");
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<string[]>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        async Task<ForceAddAPIResponse> ForceAddTransactionAsync(ForceAddRequest forceAddRequest) {            
            var response = await _httpClient.PostAsJsonAsync($"{this.baseUri}/force-add", forceAddRequest);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<ForceAddAPIResponse>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        async Task<CheckDestinationAPIResponse> CheckDestinationAsync(CheckDestinationRequest checkDestinationRequest) {
            var response = await _httpClient.PostAsJsonAsync($"{this.baseUri}/check-destination", checkDestinationRequest);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<CheckDestinationAPIResponse>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        async Task<AddEnchargementAPIResponse> CreateEnchargementAsync(CreateEncashementRequest encashementRequest) {
            var response = await _httpClient.PostAsJsonAsync($"{this.baseUri}/add-enchargement", encashementRequest);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<AddEnchargementAPIResponse>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task<bool> CheckPhoneNumberRequest(string phoneNumber) {
            string terminalPasswordDecrypted = AesEncryptionHelper.DecryptString(terminalPassword);
            string msisdnEncrypted = AesEncryptionHelper.EncryptString(phoneNumber, terminalPasswordDecrypted);
            string serviceKey = "01";
            CheckDestinationRequest destinationRequest = new CheckDestinationRequest() {
                ServiceKey = serviceKey,
                MsisdnEncrypted = msisdnEncrypted,
                Msisdn = phoneNumber,
                TerminalIdEncrypted = this.terminalIdEncrypted
            };
            try {
                var result = await CheckDestinationAsync(destinationRequest);
                if(result != null) return result.Success;
            } catch(Exception e) {
                logger.LogError(e.Message);
                return false;
            }
            return false;
        }

        public async Task<bool> AddEnchargement() {
            string terminalPasswordDecrypted = AesEncryptionHelper.DecryptString(terminalPassword);
            string checkSum = Guid.NewGuid().ToString();
            string checkSumEncrypted = AesEncryptionHelper.EncryptString(checkSum, terminalPasswordDecrypted);
            var addEnchargementRequest = new CreateEncashementRequest() {
                CheckSum = checkSum,
                CheckSumEncrypted = checkSumEncrypted,
                TerminalIdEncrypted = this.terminalIdEncrypted
            };
            try {
                var result = await CreateEnchargementAsync(addEnchargementRequest);
                return result.Success;
            } catch {
                return false;
            }
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
