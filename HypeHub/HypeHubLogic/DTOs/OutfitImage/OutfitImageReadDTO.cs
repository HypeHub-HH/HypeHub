namespace HypeHubLogic.DTOs.OutfitImage;

public record OutfitImageReadDTO
{
    public Guid Id { get; init; }
    public string Url { get; init; }
}
