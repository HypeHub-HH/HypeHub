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

    public ItemReadDTO(Guid id, string name, List<AccountItemLikeReadDTO> likes, CloathingType cloathingType, string? brand, string? model, string? colorway, decimal? price, DateTime? purchaseDate, List<ItemImageReadDTO> images)
    {
        Id = id;
        Name = name;
        Likes = likes;
        CloathingType = cloathingType;
        Brand = brand;
        Model = model;
        Colorway = colorway;
        Price = price;
        PurchaseDate = purchaseDate;
        Images = images;
    }
}
