using HypeHubLogic.DTOs.Logging;
using MediatR;

namespace HypeHubLogic.CQRS.Authentication.Commands.Post;

public class LoginAccountCommand : IRequest<LoggingReadDTO>
{
    public LoggingCreateDTO LoggingCreateDTO { get; init; }

    public LoginAccountCommand(LoggingCreateDTO loggingCreateDTO)
    {
        LoggingCreateDTO = loggingCreateDTO;
    }
}
