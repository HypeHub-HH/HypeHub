namespace HypeHubDAL.Models;

public class Outfit
{
    public Guid Id { get; init; }
    public Account Account { get; init; }
    public Guid AccountId { get; init; }
    public string Name { get; init; }
    public List<Item> Items { get; set; } = new();
    public List<Account> Likes { get; set; } = new();
    public List<string> PhotoURLs { get; init; } = new();

    public Outfit(Account owner, Guid ownerId, string name)
    {
        Id = Guid.NewGuid();
        Account = owner;
        AccountId = ownerId;
        Name = name;
    }
}