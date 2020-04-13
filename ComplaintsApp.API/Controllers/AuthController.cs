using ComplaintsApp.API.Dtos;
using ComplaintsApp.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace ComplaintsApp.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _auth;

        public AuthController(IAuthService auth)
        {
            _auth = auth;
        }

        [HttpPost("login")]
        public IActionResult Login(UserForLoginDto userForLoginDto)
        {
            var returnObject = _auth.Login(userForLoginDto);

            if (returnObject == null)
                return Unauthorized();

            return
             Ok(returnObject);
        }
    }
}