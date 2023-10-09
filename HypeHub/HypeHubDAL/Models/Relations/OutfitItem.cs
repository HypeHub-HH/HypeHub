namespace HypeHubDAL.Models.Relations;

public class OutfitItem
{
    public Guid OutfitId { get; init; }
    public Guid ItemId { get; init; }

    public OutfitItem(Guid outfitId, Guid itemId)
    {
        OutfitId = outfitId;
        ItemId = itemId;
    }
}
