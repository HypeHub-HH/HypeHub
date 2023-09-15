namespace HypeHubLogic.DTOs.Account;

public record AccountCreateDTO
{
    public string Username { get; init; }
    public bool IsPrivate { get; init; }
    public string? AvatarUrl { get; init; }
}
