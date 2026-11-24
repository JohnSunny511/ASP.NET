using System.Text.Json.Serialization;

namespace GeminiChatbotAPI.Models
{
    public class GeminiResponse
    {
        [JsonPropertyName("candidates")]
        public List<Candidate>? Candidates { get; set; }
    }

    public class Candidate
    {
        [JsonPropertyName("content")]
        public GeminiContent? Content { get; set; }
    }

    public class GeminiContent
    {
        [JsonPropertyName("parts")]
        public List<GeminiPart>? Parts { get; set; }
    }

    public class GeminiPart
    {
        [JsonPropertyName("text")]
        public string? Text { get; set; }
    }
}