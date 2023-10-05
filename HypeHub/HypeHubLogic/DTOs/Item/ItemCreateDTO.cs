using HypeHubDAL.Models.Types;

namespace HypeHubLogic.DTOs.Item;

public record ItemCreateDTO
{
    public string Name { get; set; }
    public CloathingType CloathingType { get; init; }
    public string? Brand { get; init; }
    public string? Model { get; init; }
    public string? Colorway { get; init; }
    public decimal? Price { get; init; }
    public DateTime? PurchaseDate { get; init; }

    public ItemCreateDTO(string name, CloathingType cloathingType, string? brand, string? model, string? colorway, decimal? price, DateTime? purchaseDate)
    {
        Name = name;
        CloathingType = cloathingType;
        Brand = brand;
        Model = model;
        Colorway = colorway;
        Price = price;
        PurchaseDate = purchaseDate;
    }
}
