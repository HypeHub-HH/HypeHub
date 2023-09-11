namespace HypeHubDAL.Models;

public class Wardrobe
{
    public Guid Id { get; init; }
    public Account User { get; init; }
    public Guid UserId { get; init; }
    public List<Item> Items { get; init; } = new();

    public Wardrobe(Account user, Guid userId)
    {
        Id = Guid.NewGuid();
        User = user;
        UserId = userId;
        Items = new();
    }
}
