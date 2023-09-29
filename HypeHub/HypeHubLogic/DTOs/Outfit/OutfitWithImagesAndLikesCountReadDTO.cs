using HypeHubLogic.DTOs.OutfitImage;

namespace HypeHubLogic.DTOs.Outfit;

public record OutfitWithImagesAndLikesCountReadDTO
{
    public Guid Id { get; init; }
    public string Name { get; init; }
    public DateTime CreationDate { get; init; }
    public List<OutfitImageReadDTO> Images { get; init; }
    public int Likes { get; init; }
}
