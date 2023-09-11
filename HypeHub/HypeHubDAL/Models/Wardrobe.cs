namespace HypeHubDAL.Models;

public class Wardrobe
{
    public Guid Id { get; init; }
    public Account Account { get; init; }
    public Guid AccountId { get; init; }
    public List<Item> Items { get; init; } = new();

    public Wardrobe(Guid accountId)
    {
        Id = Guid.NewGuid();
        AccountId = accountId;
    }
}
