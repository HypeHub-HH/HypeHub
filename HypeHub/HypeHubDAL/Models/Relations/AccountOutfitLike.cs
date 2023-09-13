namespace HypeHubDAL.Models.Relations;

public class AccountOutfitLike
{
    public Guid Id { get; init; }
    public Outfit Outfit { get; init; }
    public Guid OutfitId { get; init; }
    public Guid AccountId { get; init; }
}
