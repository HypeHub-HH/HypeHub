using HypeHubLogic.DTOs.Registration;
using MediatR;

namespace HypeHubLogic.CQRS.Authentication.Commands.Post;

public class RegisterAccountCommand : IRequest<RegistrationReadDTO>
{
    public RegistrationCreateDTO RegistrationCreateDTO { get; init; }

    public RegisterAccountCommand(RegistrationCreateDTO registrationCreateDTO)
    {
        RegistrationCreateDTO = registrationCreateDTO;
    }
}