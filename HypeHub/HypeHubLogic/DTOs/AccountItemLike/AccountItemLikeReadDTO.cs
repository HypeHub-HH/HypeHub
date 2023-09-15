namespace HypeHubLogic.DTOs.AccountItemLike;

public record AccountItemLikeReadDTO
{
    public Guid Id { get; init; }
    public Guid AccountId { get; init; }
}
