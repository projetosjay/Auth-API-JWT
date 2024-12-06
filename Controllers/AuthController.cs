using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class AuthController : ControllerBase
{
    private readonly TokenService _tokenService;

    public AuthController()
    {
        _tokenService = new TokenService();
    }

    [HttpPost("login")]
    public ActionResult<LoginResponse> Login([FromBody] User user)
    {
        if (user.Username == "admin" && user.Password == "123456")
        {
            var token = _tokenService.GenerateToken(user.Username);
            return new LoginResponse { Token = token };
        }

        return BadRequest("Usuário ou senha inválidos");
    }
}