namespace HypeHubLogic.DTOs.Account;

public record AccountCurrentReadDTO
{
    public Guid AccountId { get; init; }
    public string UserName { get; init; }
    public string Email { get; init; }
    public bool IsPrivate { get; init; }
    public string? AvatarURL { get; init; }
    public IList<string> Roles { get; init; }
}