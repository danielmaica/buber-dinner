using Microsoft.AspNetCore.Mvc;
using BuberDinner.Contracts.Authentication;
using BuberDinner.Application.Services.Authentication;

namespace BuberDinner.Api.Controllers
{
    [ApiController]
    [Route("auth")]
    public class AuthenticationController(IAuthenticationService authenticationService) : ControllerBase
    {
        private readonly IAuthenticationService _service = authenticationService;

        [HttpPost("register")]
        public IActionResult Register(RegisterRequest request)
        {
            AuthenticationResult authResult = _service.Register(
                request.FirstName,
                request.LastName,
                request.Email,
                request.Password
            );
            AuthenticationResponse response = new(
                authResult.User.Id,
                authResult.User.FirstName,
                authResult.User.LastName,
                authResult.User.Email,
                authResult.Token
            );
            return Ok(response);
        }

        [HttpPost("login")]
        public IActionResult Login(LoginRequest request)
        {
            AuthenticationResult authResult = _service.Login(
                request.Email,
                request.Password
            );

            if (authResult == null)
                return Unauthorized();

            AuthenticationResponse response = new(
              authResult.User.Id,
              authResult.User.FirstName,
              authResult.User.LastName,
              authResult.User.Email,
                authResult.Token
            );
            return Ok(response);
        }
    }
}

