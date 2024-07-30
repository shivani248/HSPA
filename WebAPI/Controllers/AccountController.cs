using System.IdentityModel.Tokens.Jwt;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using ServiceStack;
using WebAPI.Controllers.Dtos;
using WebAPI.Interfaces;
using WebAPI.Model;

namespace WebAPI.Controllers
{

    public class AccountController : BaseController
    {
        private readonly InterfaceUnitofWork uow;
        private readonly IConfiguration configuration;
        public AccountController(InterfaceUnitofWork uow , IConfiguration configuration)
        {
            this.configuration = configuration;
            this.uow = uow;
        }

      

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginReqDto loginReq)
        {
            var user = await uow.UserRepository.Authenticate(loginReq.UserName, loginReq.Password);
            if (user == null)
            {
                return Unauthorized();
            }
            var loginResp = new UserRespDto
            {
                UserName = user.UserName, // Assign the value of user.UserName to UserName property
                Token = CreateJWT(user) // Assign a value to the Token property
            };

            return Ok(loginResp);
;        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(LoginReqDto loginReq)
        {
            //ApiError apiError = new ApiError();

            //if (loginReq.UserName.IsEmpty() || loginReq.Password.IsEmpty())
            //{
            //    apiError.ErrorCode = BadRequest().StatusCode;
            //    apiError.ErrorMessage = "User name or password can not be blank";
            //    return BadRequest(apiError);
            //}

            if (await uow.UserRepository.UserAlreadyExists(loginReq.UserName))
            {
                //apiError.ErrorCode = BadRequest().StatusCode;
                //apiError.ErrorMessage = "User already exists, please try different user name";
                return BadRequest("user already exits , try something else");
            }

            uow.UserRepository.Register(loginReq.UserName, loginReq.Password);
            await uow.SaveAsync();
            return StatusCode(201);
        }

        //Create JWT Token
        private string CreateJWT(User user)
        {
            var secretKey = configuration.GetSection("AppSettings:Key").Value;
            var key = new SymmetricSecurityKey(Encoding.UTF8
                .GetBytes(secretKey));

            var claims = new Claim[] {
                new Claim(ClaimTypes.Name, user.UserName.ToString()),
                //new Claim(ClaimTypes.Name,user.Username),
                new Claim(ClaimTypes.NameIdentifier,user.Id.ToString())
            }; 

            var signingCredentials = new SigningCredentials(
                    key, SecurityAlgorithms.HmacSha256Signature);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddMinutes(15),
                SigningCredentials = signingCredentials
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

    }
}
