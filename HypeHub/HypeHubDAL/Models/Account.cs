namespace HypeHubDAL.Models;
public class Account
{
    public Guid Id { get; init; }
    public string Username { get; set; }
    public bool IsPrivate { get; set; }
    public List<Outfit> Outfits { get; init; } = new();
    public List<Item> Items { get; init; } = new();
    public string? AvatarUrl { get; set; }
    public Account(Guid id, string username, bool isPrivate, string? avatarUrl)
    {
        Id = id;
        Username = username;
        IsPrivate = isPrivate;
        AvatarUrl = avatarUrl;    
    }
}
