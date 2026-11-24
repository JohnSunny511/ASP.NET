using Microsoft.AspNetCore.Mvc;
using GeminiChatbotAPI.DTOs;
using GeminiChatbotAPI.Services;

namespace GeminiChatbotAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private readonly IGeminiService _geminiService;

        public ChatController(IGeminiService geminiService)
        {
            _geminiService = geminiService;
        }

        [HttpPost("send")]
        public async Task<IActionResult> SendMessage(
            [FromBody] ChatRequestDTO request)
        {
            if (string.IsNullOrWhiteSpace(request.Message))
            {
                return BadRequest("Message cannot be empty.");
            }

            try
            {
                var result = await _geminiService.SendMessageAsync(request);

                return Ok(result);
            }
            catch (HttpRequestException ex)
            {
                return StatusCode(502, new
                {
                    error = ex.Message
                });
            }
            catch (InvalidOperationException ex)
            {
                return StatusCode(500, new
                {
                    error = ex.Message
                });
            }
        }
    }
}