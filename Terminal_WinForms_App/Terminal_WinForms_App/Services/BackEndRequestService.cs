using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace Terminal_WinForms_App.Services {
    public class BackEndRequestService {
        string baseUri;
        string terminalId;
        string terminalIdEncrypted;
        string terminalPassword;
        readonly string ServiceKey = "tmcell";
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
            try {
                var response = await _httpClient.PostAsJsonAsync($"{this.baseUri}/force-add", forceAddRequest);
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<ForceAddAPIResponse>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            } catch(System.Net.Http.HttpRequestException e) {
                await logger.LogWarning($"Force-Add Error: {e.Message} \n Number: {forceAddRequest.Msisdn} \n {forceAddRequest.Amount}");
            }
            return new ForceAddAPIResponse();
        }

        async Task<CheckDestinationAPIResponse> CheckDestinationAsync(CheckDestinationRequest checkDestinationRequest) {
            try {
                var response = await _httpClient.PostAsJsonAsync($"{this.baseUri}/check-destination", checkDestinationRequest);
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<CheckDestinationAPIResponse>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            } catch(Exception ex) {
                await logger.LogWarning($"Check-Destination Error: {ex.Message} \n Number: {checkDestinationRequest.Msisdn}");
            }
            return new CheckDestinationAPIResponse();
        }

        public async Task<PingTerminalResponse> PingTerminalRequest() {
            try {
                APIRequestBase pingRequest = new APIRequestBase() { TerminalIdEncrypted = this.terminalIdEncrypted };
                var response = await _httpClient.PostAsJsonAsync($"{this.baseUri}/ping-terminal", pingRequest);
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<PingTerminalResponse>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            } catch(Exception ex) {
              return new PingTerminalResponse();
            }            
        }

        async Task<AddEnchargementAPIResponse> CreateEnchargementAsync(CreateEncashementRequest encashementRequest) {
            try {
                var response = await _httpClient.PostAsJsonAsync($"{this.baseUri}/add-enchargement", encashementRequest);
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<AddEnchargementAPIResponse>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            } catch(System.Net.Http.HttpRequestException e) {
                await logger.LogWarning($"Enchargement Error: {e.Message} \n Sum: {encashementRequest.Sum}");
            }
            return new AddEnchargementAPIResponse();
        }

        async Task<LogTerminalResponse> LogTerminalAsync(TerminalLogRequest logRequest) {
            try {
                var response = await _httpClient.PostAsJsonAsync($"{this.baseUri}/terminal-log", logRequest);
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<LogTerminalResponse>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            } catch {
                return new LogTerminalResponse();
            }
        }

        public async Task<RegisterTerminalResponse> RegisterTerminalResuest(RegisterTerminalRequest registerTerminalRequest) {
            try {
                var response = await _httpClient.PostAsJsonAsync($"{this.baseUri}/register-terminal", registerTerminalRequest);
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<RegisterTerminalResponse>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            } catch {
                return new RegisterTerminalResponse();
            }
        }

        public async Task<bool> CheckPhoneNumberRequest(string phoneNumber) {
            string terminalPasswordDecrypted = AesEncryptionHelper.DecryptString(terminalPassword);
            string msisdnEncrypted = AesEncryptionHelper.EncryptString(phoneNumber, terminalPasswordDecrypted);
            CheckDestinationRequest destinationRequest = new CheckDestinationRequest() {
                ServiceKey = ServiceKey,
                MsisdnEncrypted = msisdnEncrypted,
                Msisdn = phoneNumber,
                TerminalIdEncrypted = this.terminalIdEncrypted
            };
            try {
                var result = await CheckDestinationAsync(destinationRequest);

                if(result != null) {
                    CurrentState.DealerTotal = result.DealerTotal;
                    return result.Success;
                }
            } catch(Exception e) {
                await logger.LogInfo(e.Message);
                return false;
            }
            return false;
        }

        public async Task<bool> AddEnchargement(int passCode, int totalSum) {
            string terminalPasswordDecrypted = AesEncryptionHelper.DecryptString(terminalPassword);
            string checkSum = Guid.NewGuid().ToString();
            string checkSumEncrypted = AesEncryptionHelper.EncryptString(checkSum, terminalPasswordDecrypted);
            var addEnchargementRequest = new CreateEncashementRequest() {
                CheckSum = checkSum,
                CheckSumEncrypted = checkSumEncrypted,
                TerminalIdEncrypted = this.terminalIdEncrypted,
                EncashmentPasscode = passCode,
                Sum = totalSum
            };
            try {
                var result = await CreateEnchargementAsync(addEnchargementRequest);
                return result.Success;
            } catch {
                return false;
            }
        }

        public async Task<ForceAddAPIResponse> MakePaymentRequest(string phoneNumber, int amount) {
            string terminalPasswordDecrypted = AesEncryptionHelper.DecryptString(terminalPassword);
            string msisdnEncrypted = AesEncryptionHelper.EncryptString(phoneNumber, terminalPasswordDecrypted);
            var addRequest = new ForceAddRequest() {
                Amount = amount,
                Msisdn = phoneNumber,
                MsisdnEncrypted = msisdnEncrypted,
                ServiceKey = ServiceKey,
                TerminalIdEncrypted = terminalIdEncrypted
            };
            return await ForceAddTransactionAsync(addRequest);
        }

        public void CassetteRemovedAndCleanedRequest() {

        }

        public async Task LogWriteRequest(string message, LogType type) {
            var logRequest = new TerminalLogRequest() { LogInfo = message, Type = type, TerminalIdEncrypted = this.terminalIdEncrypted };
            var result = await LogTerminalAsync(logRequest);
        }

        public async Task LogRepaired() {
            var logRequest = new TerminalLogRequest() { LogInfo = "Работа востановлено", Type = LogType.Repaired, TerminalIdEncrypted = this.terminalIdEncrypted };
            var result = await LogTerminalAsync(logRequest);
        }
    }
}
