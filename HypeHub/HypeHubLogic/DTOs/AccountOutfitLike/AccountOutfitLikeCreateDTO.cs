namespace HypeHubLogic.DTOs.AccountOutfitLike;

public record AccountOutfitLikeCreateDTO
{
    public Guid OutfitId { get; init; }
    public Guid AccountId { get; init; }
}
