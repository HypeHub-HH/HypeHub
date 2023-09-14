namespace HypeHubLogic.DTOs.Account;

public class AccountReadDTO
{
    public Guid Id { get; init; }
    public string Username { get; init; }
    public string? AvatarUrl { get; init; }
}
