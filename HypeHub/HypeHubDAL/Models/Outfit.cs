using HypeHubDAL.Models.Relations;

namespace HypeHubDAL.Models;

public class Outfit
{
    public Guid Id { get; init; }
    public Account Account { get; init; }
    public Guid AccountId { get; init; }
    public string Name { get; init; }
    public DateTime CreationDate { get; init; } = DateTime.Now;
    public List<Item> Items { get; init; } = new();
    public List<AccountOutfitLike> Likes { get; init; } = new();
    public List<OutfitImage> Images { get; init; } = new();

    public Outfit(Guid accountId, string name)
    {
        Id = Guid.NewGuid();
        AccountId = accountId;
        Name = name;
    }
}