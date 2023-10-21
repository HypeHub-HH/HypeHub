using HypeHubDAL.Models;
using System.Security.Claims;

namespace HypeHubLogic.Services.Interfaces;
public interface ITokenService
{
    public string CreateToken(ApplicationUser user, IList<string> roles);
    public string GenerateRefreshToken();
    public ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
}
