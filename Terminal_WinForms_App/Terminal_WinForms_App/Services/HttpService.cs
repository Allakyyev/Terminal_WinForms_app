using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Terminal_WinForms_App.Services {
    public class HttpService {
        private readonly HttpClient _httpClient;

        public HttpService() {
            _httpClient = new HttpClient();
            // Optionally configure the HttpClient here (e.g., setting default headers)
        }

        public async Task<HttpResponseMessage> PostAsync(string url, string jsonContent) {
            if(string.IsNullOrEmpty(url))
                throw new ArgumentNullException(nameof(url));

            if(string.IsNullOrEmpty(jsonContent))
                throw new ArgumentNullException(nameof(jsonContent));

            try {
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await _httpClient.PostAsync(url, content);

                response.EnsureSuccessStatusCode(); // Throw if not a success code.

                return response;
            } catch(HttpRequestException e) {
                // Log the exception (you can use any logging framework or custom logging logic)
                Console.WriteLine($"Request error: {e.Message}");
                throw;
            }
        }

        public void Dispose() {
            _httpClient.Dispose();
        }
    }
}
