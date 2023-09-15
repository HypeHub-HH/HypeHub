namespace HypeHubLogic.DTOs.Outfit;

public record OutfitCreateDTO
{
    public Guid AccountId { get; init; }
    public string Name { get; init; }
}
