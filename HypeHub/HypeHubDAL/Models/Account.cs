using HypeHubDAL.Models.Types;

namespace HypeHubDAL.Models;

public class Account
{
    public Guid Id { get; init; }
    public string Username { get; set; }
    public AccountCredentials Credentials { get; init; }
    public bool IsPrivate { get; set; }
    public AccountTypes AccountTypes { get; set; }
    public Wardrobe Wardrobe { get; init; }
    public List<Outfit> Outfits { get; init; } = new();
    public List<Outfit> LikedOutfits { get; init; } = new();
    public List<Item> LikedItems { get; init; } = new();
    public string? AvatarUrl {get; set;}

    public Account(string username, bool isPrivate, AccountTypes accountTypes, string? avatarUrl)
    {
        Id = Guid.NewGuid();
        Username = username;
        IsPrivate = isPrivate;
        AccountTypes = accountTypes;
        AvatarUrl = avatarUrl;
    }
}
