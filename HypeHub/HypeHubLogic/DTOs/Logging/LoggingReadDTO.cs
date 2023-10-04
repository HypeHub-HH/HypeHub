namespace HypeHubLogic.DTOs.Logging;

public record LoggingReadDTO
{
    public string Token { get; init; }
    public string RefreshToken { get; init; }
}