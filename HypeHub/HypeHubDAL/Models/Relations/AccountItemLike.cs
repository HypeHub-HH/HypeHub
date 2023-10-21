namespace HypeHubDAL.Models.Relations;
public class AccountItemLike
{
    public Guid Id { get; init; }
    public Item Item { get; init; }
    public Guid ItemId { get; init; }
    public Guid AccountId { get; init; }
    public AccountItemLike(Guid itemId, Guid accountId)
    {
        Id = Guid.NewGuid();
        ItemId = itemId;
        AccountId = accountId;
    }
}
