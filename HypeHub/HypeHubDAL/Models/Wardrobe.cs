namespace HypeHubDAL.Models;

public class Wardrobe
{
    public Guid Id { get; init; }
    public Account Account { get; init; }
    public Guid AccountId { get; init; }
    public List<Item> Items { get; init; } = new();

    public Wardrobe(Account user, Guid userId)
    {
        Id = Guid.NewGuid();
        Account = user;
        AccountId = userId;
        Items = new();
    }
}
