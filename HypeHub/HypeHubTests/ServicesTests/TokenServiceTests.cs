using HypeHubDAL.Models;
using HypeHubLogic.Services;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Configuration;
using HypeHubLogic.Services.Interfaces;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Security.Claims;

namespace HypeHubTests.ServicesTests;

[TestFixture]
public class TokenServiceTests
{
    private ITokenService _tokenService;
    private IConfiguration _configuration;

    [SetUp]
    public void Setup()
    {
        _configuration = new ConfigurationBuilder()
            .AddUserSecrets<TokenServiceTests>()
            .Build();
        _tokenService = new TokenService(_configuration);
    }

    [Test]
    public void CreateToken_ValidUserAndRoles_ReturnsToken()
    {
        // Arrange
        var user = new ApplicationUser { Id = Guid.NewGuid().ToString() };
        var roles = new List<string> { "role1", "role2" };
        var tokenHandler = new JwtSecurityTokenHandler();
        var tokenValidationParameters = new TokenValidationParameters
        {
            ClockSkew = TimeSpan.Zero,
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = _configuration["JWT:ValidIssuer"],
            ValidAudience = _configuration["JWT:ValidAudience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["IssuerSigningKey"]))
        };

        // Act
        var token = _tokenService.CreateToken(user, roles);
        var validationResult = tokenHandler.ValidateTokenAsync(token, tokenValidationParameters);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(validationResult.IsCompletedSuccessfully, Is.True);
            Assert.That(token, Is.Not.Null);
        });
    }

    [Test]
    public void GenerateRefreshToken_GeneratesValidToken()
    {
        // Act
        var refreshToken = _tokenService.GenerateRefreshToken();

        // Assert
        Assert.That(refreshToken, Is.Not.Null);
    }

    [Test]
    public void GetPrincipalFromExpiredToken_ValidToken_ReturnsPrincipal()
    {
        // Arrange
        var credentials = new SigningCredentials(
              new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["IssuerSigningKey"])), SecurityAlgorithms.HmacSha256);
        _ = int.TryParse(_configuration["JWT:TokenValidityInMinutes"], out int expirationMinutes);
        var expiration = DateTime.UtcNow.AddMinutes(expirationMinutes);
        var claims = new[]
            {
                new Claim(ClaimTypes.Name, "testUser"),
                new Claim(ClaimTypes.Role, "testRole")
            };

        var token = new JwtSecurityToken(
            _configuration["JWT:ValidIssuer"],
            _configuration["JWT:ValidAudience"],
            claims,
            expires: expiration,
            signingCredentials: credentials
        );
        var tokenHandler = new JwtSecurityTokenHandler();

        var tokenString = tokenHandler.WriteToken(token);

        // Act
        var principal = _tokenService.GetPrincipalFromExpiredToken(tokenString);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(principal, Is.Not.Null);
            Assert.That(principal.Identity.IsAuthenticated, Is.True);
            Assert.That(principal.Identity.Name, Is.EqualTo("testUser"));
            Assert.That(principal.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Role)?.Value, Is.EqualTo("testRole"));
        });
    }
}