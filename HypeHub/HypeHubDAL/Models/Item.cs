using HypeHubDAL.Models.Relations;
using HypeHubDAL.Models.Types;

namespace HypeHubDAL.Models;

public class Item
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Account? Account { get; set; }
    public Guid? AccountId { get; set; }
    public List<Outfit> Outfits { get; } = new();
    public List<AccountItemLike> Likes { get; init; } = new();
    public CloathingType CloathingType { get; set; }
    public string? Brand { get; set; }
    public string? Model { get; set; }
    public string? Colorway { get; set; }
    public decimal? Price { get; set; }
    public DateTime? PurchaseDate { get; set; }
    public List<ItemImage> Images { get; init; } = new();

    public Item(string name, Guid accountId, CloathingType cloathingType, string? brand, string? model, string? colorway, decimal? price, DateTime? purchaseDate)
    {
        Id = Guid.NewGuid();
        Name = name;
        AccountId = accountId;
        CloathingType = cloathingType;
        Brand = brand;
        Model = model;
        Colorway = colorway;
        Price = price;
        PurchaseDate = purchaseDate;
    }
}
