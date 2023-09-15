namespace HypeHubLogic.DTOs.AccountItemLike;

public record AccountItemLikeCreateDTO
{
    public Guid ItemId { get; init; }
    public Guid AccountId { get; init; }
}
