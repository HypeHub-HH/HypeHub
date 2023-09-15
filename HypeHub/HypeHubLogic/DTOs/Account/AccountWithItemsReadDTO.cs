using HypeHubLogic.DTOs.Item;

namespace HypeHubLogic.DTOs.Account;

public record AccountWithItemsReadDTO
{
    public Guid Id { get; init; }
    public string Username { get; init; }
    public List<ItemReadDTO> Items { get; init; }
    public string? AvatarUrl { get; init; }
}
