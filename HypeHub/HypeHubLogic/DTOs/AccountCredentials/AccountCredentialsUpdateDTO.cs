namespace HypeHubLogic.DTOs.AccountCredentials;

public record AccountCredentialsUpdateDTO
{
    public Guid Id { get; init; }
    public string? Password { get; init; }
    public string? Email { get; init; }
}
