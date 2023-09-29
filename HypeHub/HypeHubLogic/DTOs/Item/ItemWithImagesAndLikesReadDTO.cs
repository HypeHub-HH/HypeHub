using HypeHubDAL.Models.Types;
using HypeHubLogic.DTOs.AccountItemLike;
using HypeHubLogic.DTOs.ItemImage;

namespace HypeHubLogic.DTOs.Item;

public record ItemWithImagesAndLikesReadDTO
{
    public Guid Id { get; init; }
    public string Name { get; init; }
    public List<AccountItemLikeReadDTO> Likes { get; init; }
    public CloathingType CloathingType { get; init; }
    public string? Brand { get; init; }
    public string? Model { get; init; }
    public string? Colorway { get; init; }
    public decimal? Price { get; init; }
    public DateTime? PurchaseDate { get; init; }
    public List<ItemImageReadDTO> Images { get; init; }
}
