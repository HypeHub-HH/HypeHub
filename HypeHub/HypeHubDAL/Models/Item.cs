using HypeHubDAL.Models.Types;

namespace HypeHubDAL.Models;

public class Item
{
    public Guid Id { get; init; }
    public string Name { get; set; }
    public Wardrobe Wardrobe { get; init; }
    public Guid WardrobeId { get; init; }
    public List<Outfit> Outfits { get; init; } = new();
    public CloathingType CloathingType { get; set; }
    public string? Brand { get; set; }
    public string? Model { get; set; }
    public string? Colorway { get; set; }
    public decimal? Price { get; set; }
    public DateTime? PurchaseDate { get; set; }
    public List<ItemImage> Images { get; init; } = new();
    public List<Account> Likes { get; init; } = new();

    public Item(string name, Guid wardrobeId, CloathingType cloathingType, string? brand, string? model, string? colorway, decimal? price, DateTime? purchaseDate)
    {
        Id = Guid.NewGuid();
        Name = name;
        WardrobeId = wardrobeId;
        CloathingType = cloathingType;
        Brand = brand;
        Model = model;
        Colorway = colorway;
        Price = price;
        PurchaseDate = purchaseDate;
    }
}
