using System.Net.Http.Json;
using System.Text.Json;
using GeminiChatbotAPI.DTOs;
using GeminiChatbotAPI.Models;

namespace GeminiChatbotAPI.Services
{
    public class GeminiService : IGeminiService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public GeminiService(
            HttpClient httpClient,
            IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public async Task<ChatResponseDTO> SendMessageAsync(ChatRequestDTO request)
        {
            string apiKey = _configuration["Gemini:ApiKey"]
                ?? throw new InvalidOperationException("Gemini API key is missing.");

            string model = _configuration["Gemini:Model"] ?? "gemini-2.5-flash";

            string url = $"https://generativelanguage.googleapis.com/v1beta/models/{model}:generateContent";

            var requestBody = new
            {
                contents = new[]
                {
            new
            {
                parts = new[]
                {
                    new { text = request.Message }
                }
            }
        }
            };

            using var httpRequest = new HttpRequestMessage(HttpMethod.Post, url);

            httpRequest.Headers.Add("x-goog-api-key", apiKey);
            httpRequest.Content = JsonContent.Create(requestBody);

            var response = await _httpClient.SendAsync(httpRequest);

            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadFromJsonAsync<GeminiResponse>();

            return new ChatResponseDTO
            {
                Response = result?.Candidates?.FirstOrDefault()?
                    .Content?.Parts?.FirstOrDefault()?.Text ?? "No response generated."
            };
        }
    }
}