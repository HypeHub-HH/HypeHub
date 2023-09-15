namespace HypeHubDAL.Models;

public class OutfitImage
{
    public Guid Id { get; init; }
    public Outfit Outfit { get; init; }
    public Guid OutfitId { get; init; }
    public string Url { get; init; }

    public OutfitImage(Guid outfitId, string url)
    {
        Id = Guid.NewGuid();
        OutfitId = outfitId;
        Url = url;
    }
}
