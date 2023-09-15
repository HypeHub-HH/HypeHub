namespace HypeHubLogic.DTOs.Account;

public record AccountReadDTO
{
    public Guid Id { get; init; }
    public string Username { get; init; }
    public string? AvatarUrl { get; init; }
}
