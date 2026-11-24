using MailKit;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using sendmailcore1.Models;

namespace MailSendingCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public EmailController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost("Send")]
        public async Task<IActionResult> SendEmail(EmailModel obj)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(obj.ToEmail) ||
                    string.IsNullOrWhiteSpace(obj.Subject) ||
                    string.IsNullOrWhiteSpace(obj.Message))
                {
                    return BadRequest("All fields are required.");
                }

                var email = new MimeMessage();

                email.From.Add(new MailboxAddress(
                    "Email API",
                    _configuration["EmailSettings:Email"]));

                email.To.Add(MailboxAddress.Parse(obj.ToEmail));

                email.Subject = obj.Subject;

                email.Body = new TextPart("plain")
                {
                    Text = obj.Message
                };

                using var smtp = new SmtpClient();

                await smtp.ConnectAsync(
                    _configuration["EmailSettings:Host"],
                    int.Parse(_configuration["EmailSettings:Port"]),
                    SecureSocketOptions.StartTls);

                await smtp.AuthenticateAsync(
                    _configuration["EmailSettings:Email"],
                    _configuration["EmailSettings:Password"]);

                await smtp.SendAsync(email, CancellationToken.None);

                await smtp.DisconnectAsync(true);

                return Ok("Email sent successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}