using Microsoft.AspNetCore.Identity;

namespace HypeHubLogic.Services.Interfaces;

public interface ITokenService
{
    public string CreateToken(IdentityUser user, IList<string> roles);
}
