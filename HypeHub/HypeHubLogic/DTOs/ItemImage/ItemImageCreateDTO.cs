namespace HypeHubLogic.DTOs.ItemImage;
public record ItemImageCreateDTO
{
    public Guid ItemId { get; init; }
    public string Url { get; init; }
}
