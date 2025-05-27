using BuberDinner.Application.Common.Interfaces.Authentication;

namespace BuberDinner.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
  private readonly IJwtTokenGenerator _jwtTokenGenerator;

  public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
  {
    _jwtTokenGenerator = jwtTokenGenerator;
  }

  public AuthenticationResult Register(string firstName, string lastName, string email, string password)
  {
    // ToDo: Check if user already exists

    // Create user (generate unique ID, hash password, etc.)

    // Create JWT token (using a JWT token generator service)
    Guid userId = Guid.NewGuid();
    string token = _jwtTokenGenerator.GenerateToken(
      userId,
      email,
      firstName,
      lastName
    );

    return new AuthenticationResult(
      Guid.NewGuid(),
      firstName,
      lastName,
      email,
     token
    );
  }

  public AuthenticationResult Login(string email, string password)
  {
    return new AuthenticationResult(
      Guid.NewGuid(),
      "FirstName",
      "LastName",
      email,
      Guid.NewGuid().ToString()
    );
  }
}