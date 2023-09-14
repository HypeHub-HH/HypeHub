using HypeHubDAL.Models.Types;
using HypeHubLogic.DTOs.ItemImage;
using HypeHubLogic.DTOs.AccountItemLike;

namespace HypeHubLogic.DTOs.Item;

public class ItemReadDTO
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
