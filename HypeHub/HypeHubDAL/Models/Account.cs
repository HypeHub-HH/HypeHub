using HypeHubDAL.Models.Types;

namespace HypeHubDAL.Models;

public class Account
{
    public Guid Id { get; init; }
    public string Username { get; set; }
    public bool IsPrivate { get; set; }
    public AccountTypes AccountTypes { get; set; }
    public List<Outfit> Outfits { get; init; } = new();
    public List<Item> Items { get; init; } = new();
    public string? AvatarUrl { get; set; }

    public Account(Guid id, string username, bool isPrivate, AccountTypes accountTypes, string? avatarUrl)
    {
        Id = id;
        Username = username;
        IsPrivate = isPrivate;
        AccountTypes = accountTypes;
        AvatarUrl = avatarUrl;    
    }
}
