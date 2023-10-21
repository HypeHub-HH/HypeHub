namespace HypeHubLogic.DTOs.Account;
public record AccountGeneralInfoReadDTO
{
    public Guid Id { get; init; }
    public string Username { get; init; }
    public string? AvatarUrl { get; init; }
}
