using HypeHubLogic.DTOs.Account;

namespace HypeHubLogic.DTOs.AccountOutfitLike;
public record AccountOutfitLikeReadDTO
{
    public Guid AccountId { get; init; }
    public AccountGeneralInfoReadDTO? Account { get; set; }
}
