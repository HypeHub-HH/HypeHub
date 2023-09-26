namespace HypeHubLogic.DTOs.AccountItemLike;

public record AccountItemLikeCreateDTO
{
    public Guid ItemId { get; init; }
    public Guid AccountId { get; init; }
    public AccountItemLikeCreateDTO(Guid itemId, Guid accountId)
    {
        ItemId = itemId;
        AccountId = accountId;
    }
}
