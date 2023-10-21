namespace HypeHubLogic.DTOs.Account;
public record AccountUpdateDTO
{
    public Guid Id { get; init; }
    public string? Username { get; init; }
    public bool? IsPrivate { get; init; }
    public string? AvatarUrl { get; init; }
}
