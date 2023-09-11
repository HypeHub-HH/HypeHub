namespace HypeHubDAL.Models;

public class OutfitImage
{
    public Guid Id { get; init; }
    public Outfit Outfit { get; init; }
    public Guid OutfitId { get; init; }
    public string Url { get; init; }

    public OutfitImage(Guid id, Guid outfitId, string url)
    {
        Id = id;
        OutfitId = outfitId;
        Url = url;
    }
}
