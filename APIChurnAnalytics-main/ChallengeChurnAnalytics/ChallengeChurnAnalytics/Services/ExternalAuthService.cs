
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ChallengeChurnAnalytics.Services
{
    public class ExternalAuthService
    {
        private readonly HttpClient _httpClient;

        public ExternalAuthService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> AuthenticateUserAsync(string token)
        {
            // Placeholder for real API URL
            var apiUrl = "https://api.external-service.com/authenticate";
            var request = new HttpRequestMessage(HttpMethod.Post, apiUrl);
            request.Headers.Add("Authorization", $"Bearer {token}");

            var response = await _httpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }

            throw new Exception("Authentication failed");
        }
    }
}
