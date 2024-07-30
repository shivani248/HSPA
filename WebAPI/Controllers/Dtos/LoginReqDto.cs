namespace WebAPI.Controllers.Dtos
{
    public class LoginReqDto
    {
        public required string UserName { get; set; }
        public required string Password { get; set; }
    }
}
