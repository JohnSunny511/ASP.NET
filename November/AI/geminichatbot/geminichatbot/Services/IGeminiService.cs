using GeminiChatbotAPI.DTOs;

namespace GeminiChatbotAPI.Services
{
    public interface IGeminiService
    {
        Task<ChatResponseDTO> SendMessageAsync(ChatRequestDTO request);
    }
}