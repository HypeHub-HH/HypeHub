namespace HypeHubLogic.DTOs.Registration;

public record RegistrationCreateDTO
{
    public string Email { get; init; }
    public string Username { get; init; }
    public string Password { get; init; }
}
