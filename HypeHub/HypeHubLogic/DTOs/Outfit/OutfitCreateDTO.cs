namespace HypeHubLogic.DTOs.Outfit;
public record OutfitCreateDTO
{
    public string Name { get; init; }
    public List<Guid> Items { get; init; }
    public List<string> Images { get; init; }
}
