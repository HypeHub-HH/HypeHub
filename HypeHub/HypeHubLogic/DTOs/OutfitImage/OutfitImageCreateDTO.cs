namespace HypeHubLogic.DTOs.OutfitImage;

public record OutfitImageCreateDTO
{
    public Guid OutfitId { get; init; }
    public string Url { get; init; }
}
