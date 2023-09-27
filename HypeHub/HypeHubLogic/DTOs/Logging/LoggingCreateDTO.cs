namespace HypeHubLogic.DTOs.Logging;

public record LoggingCreateDTO
{
    public string EmailOrUsername { get; init; }
    public string Password { get; init; }
}