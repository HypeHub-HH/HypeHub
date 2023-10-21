namespace HypeHubLogic.DTOs.Outfit;
public record OutfitGenerallReadDTO
{
    public Guid Id { get; init; }
    public Guid AccountId { get; init; }
    public string Name { get; init; }
    public DateTime CreationDate { get; init; }
}
