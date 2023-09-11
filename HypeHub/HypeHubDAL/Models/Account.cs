using HypeHubDAL.Models.Types;

namespace HypeHubDAL.Models;

public class Account
{
    public Guid Id { get; set; }
    public string Username { get; set; }
    public AccountCredentials Credentials { get; set; }
    public bool IsPrivate { get; set; }
    public AccountTypes AccountTypes { get; set; }
    public string? AvatarUrl {get; set;}
    public Wardrobe Wardrobe { get; set; }
    public List<Outfit> Outfits { get; set; }
}
