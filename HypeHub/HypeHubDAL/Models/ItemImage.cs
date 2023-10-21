namespace HypeHubDAL.Models;
public class ItemImage
{
    public Guid Id { get; init; }
    public Item Item { get; init; }
    public Guid ItemId { get; init; }
    public string Url { get; init; }
    public ItemImage(Guid itemId, string url)
    {
        Id = Guid.NewGuid();
        ItemId = itemId;
        Url = url;
    }
}
