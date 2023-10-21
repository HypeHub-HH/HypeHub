namespace HypeHubLogic.DTOs.ItemImage;
public record ItemImageReadDTO
{
    public Guid Id { get; init; }
    public Guid ItemId { get; init; }
    public string Url { get; init; }
}
