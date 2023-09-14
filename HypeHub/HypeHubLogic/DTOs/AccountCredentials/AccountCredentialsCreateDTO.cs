namespace HypeHubLogic.DTOs.AccountCredentials;

public class AccountCredentialsCreateDTO
{
    public Guid AccountId { get; init; }
    public string Password { get; init; }
    public string Email { get; init; }
}
