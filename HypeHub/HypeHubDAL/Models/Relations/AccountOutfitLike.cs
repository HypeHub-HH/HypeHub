namespace HypeHubDAL.Models.Relations;
public class AccountOutfitLike
{
    public Guid Id { get; init; }
    public Outfit Outfit { get; init; }
    public Guid OutfitId { get; init; }
    public Guid AccountId { get; init; }
    public AccountOutfitLike(Guid outfitId, Guid accountId)
    {
        Id = Guid.NewGuid();
        OutfitId = outfitId;
        AccountId = accountId;
    }
}
