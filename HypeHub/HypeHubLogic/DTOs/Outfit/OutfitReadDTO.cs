using HypeHubLogic.DTOs.AccountOutfitLike;
using HypeHubLogic.DTOs.Item;
using HypeHubLogic.DTOs.OutfitImage;

namespace HypeHubLogic.DTOs.Outfit;

public record OutfitReadDTO
{
    public Guid Id { get; init; }
    public Guid AccountId { get; init; }
    public string Name { get; init; }
    public DateTime CreationDate { get; init; }
    public List<ItemReadDTO> Items { get; init; }
    public List<AccountOutfitLikeReadDTO> Likes { get; init; }
    public List<OutfitImageReadDTO> Images { get; init; }
}
