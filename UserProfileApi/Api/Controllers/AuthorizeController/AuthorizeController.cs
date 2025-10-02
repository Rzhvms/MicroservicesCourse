using Microsoft.AspNetCore.Mvc;

namespace UserProfileApi.Controllers.AuthorizeController;

[ApiController]
[Route("api/auth")]
public class AuthorizeController : ControllerBase
{
    [HttpGet("me")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetCurrentUserInfo()
    {
        
    }
    
    [HttpPost("register")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> RegisterUser()
    {
        
    }

    [HttpPost("login")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> LoginUser()
    {
        
    }
}