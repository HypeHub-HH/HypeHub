using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace HypeHubLogic.Services.Interfaces;

public interface ITokenService
{
    public string CreateToken(IdentityUser user, IList<string> roles);
    public string GenerateRefreshToken();
    public ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
}
