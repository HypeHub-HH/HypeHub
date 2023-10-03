using Microsoft.AspNetCore.Identity;

namespace HypeHubDAL.Models;

public class ApplicationUser : IdentityUser
{
    public string? RefreshToken { get; set; }
    public DateTime RefreshTokenExpiryTime { get; set; }
}
