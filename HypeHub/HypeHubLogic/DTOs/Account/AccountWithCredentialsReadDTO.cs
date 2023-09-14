using HypeHubLogic.DTOs.AccountCredentials;

namespace HypeHubLogic.DTOs.Account;

public class AccountWithCredentialsReadDTO
{
    public Guid Id { get; init; }
    public AccountCredentialsReadDTO Credentials { get; init; }
    public string Username { get; init; }
    public bool IsPrivate { get; init; }
    public string? AvatarUrl { get; init; }
}
