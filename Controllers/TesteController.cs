using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class TesteController : ControllerBase
{
    [HttpGet]
    [Authorize]
    public ActionResult<string> Get()
    {
        return $"Olá {User.Identity.Name}, você está autenticado!";
    }
}