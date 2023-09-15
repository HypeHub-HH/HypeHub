namespace HypeHubLogic.DTOs.AccountCredentials;

public record AccountCredentialsCreateDTO
{
    public string Password { get; init; }
    public string Email { get; init; }
}
