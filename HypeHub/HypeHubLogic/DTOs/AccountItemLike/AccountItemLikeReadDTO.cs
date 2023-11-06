using HypeHubLogic.DTOs.Account;

namespace HypeHubLogic.DTOs.AccountItemLike;
public record AccountItemLikeReadDTO
{
    public Guid AccountId { get; init; }
    public AccountGeneralInfoReadDTO? Account { get; set; }
}
