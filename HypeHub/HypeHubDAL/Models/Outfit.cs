namespace HypeHubDAL.Models;

public class Outfit
{
    public Guid Id { get; init; }
    public Account Owner { get; init; }
    public Guid OwnerId { get; init; }
    public string Name { get; init; }
    public List<Item> Items { get; set; } = new();
    public List<Account> Likes { get; set; } = new();
    public List<string> PhotoURLs { get; init; } = new();

    public Outfit(Account owner, Guid ownerId, string name)
    {
        Id = Guid.NewGuid();
        Owner = owner;
        OwnerId = ownerId;
        Name = name;
    }
}