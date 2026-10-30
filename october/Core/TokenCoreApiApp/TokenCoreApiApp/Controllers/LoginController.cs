using TokenCoreApiApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TokenCoreApiApp.Controllers
{
    //[Route("api/[Login]")]
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        EmpDBclss dbobj = new EmpDBclss();

        private readonly IConfiguration _configuration;

        public LoginController(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        // GET: api/<LoginController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<LoginController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LoginController>
        [HttpPost]
        public IActionResult Post([FromBody] LoginModel model)
        {
            if (!string.IsNullOrEmpty(model.UserID) && !string.IsNullOrEmpty(model.UserPWD))
            {
                var User = dbobj.LoginDB(model);
                if (User != null && User.UserID != null)
                {
                    var authClaims = new List<Claim>
                    {
                        new Claim("logId",User.LogId.ToString()),
                        new Claim("UId",User.UserID),
                        new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
                        //Globally Unique Identifier
                        //This can be used to prevent JWT token abuse
                        //The "jti" (JWT ID) claim provieds a unique identifier for the JWT
                        //
                    };
                    var token = CreateToken(authClaims);
                    var tresponse = new TokenResponse();
                    tresponse.Token = new JwtSecurityTokenHandler().WriteToken(token);
                    return Ok(tresponse);
                }
                else
                {
                    return Unauthorized("No data found,invalid user id password");
                }
            }
            else
            {
                return Unauthorized("No data,please enter valid userid password");
            }
        }



            private JwtSecurityToken CreateToken(List<Claim> authClaims)
            {
                var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));
                _ = int.TryParse(_configuration["JWT:TokenValidityInMinutes"],
                out int tokenValidityInMinutes);
                var token = new JwtSecurityToken
                (
                    issuer: _configuration["JWT:ValidIssuer"],
                    audience: _configuration["JWT:ValidAudience"],
                    expires: DateTime.Now.AddMinutes(tokenValidityInMinutes),
                    claims: authClaims,
                    signingCredentials: new SigningCredentials(authSigningKey,
                    SecurityAlgorithms.HmacSha256)
                );
            return token;
        }

        // PUT api/<LoginController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LoginController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
