using HypeHubLogic.DTOs.Account;

namespace HypeHubLogic.DTOs.AccountOutfitLike;
public record AccountOutfitLikeReadDTO
{
    public Guid Id { get; init; }
    public Guid AccountId { get; init; }
    public AccountGeneralInfoReadDTO? Account { get; set; }
}
