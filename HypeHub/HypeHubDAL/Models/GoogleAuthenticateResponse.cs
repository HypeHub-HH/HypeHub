namespace HypeHubDAL.Models;

public record GoogleAuthenticateResponse
{
    public bool AccountExist { get; init; }
    public Guid? AccountId { get; init; }
    public string? UserName { get; init; }
    public string? Email { get; init; }
    public string? AvatarURL { get; init; }
    public string? Token { get; init; }
    public string? RefreshToken { get; init; }
}
