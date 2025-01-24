using Microsoft.AspNetCore.Mvc;

namespace SistemaDeGaleriaOnline.Api.Controllers.Account;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    [HttpPost("register/user")]
    public IActionResult Register()
    {
        return Ok();
    }

    [HttpPost("register/artist")]
    public IActionResult RegisterArtist()
    {
        return Ok();
    }
}
