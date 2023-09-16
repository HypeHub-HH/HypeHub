using HypeHubDAL.Models.Types;

namespace HypeHubLogic.DTOs.Item;

public record ItemUpdateDTO
{
    public Guid Id { get; init; }
    public string? Name { get; init; }
    public CloathingType? CloathingType { get; init; }
    public string? Brand { get; init; }
    public string? Model { get; init; }
    public string? Colorway { get; init; }
    public decimal? Price { get; init; }
    public DateTime? PurchaseDate { get; init; }
}
