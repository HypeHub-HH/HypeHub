using HypeHubLogic.CQRS.Authentication.Commands.Post;
using HypeHubLogic.DTOs.Logging;
using HypeHubLogic.DTOs.Registration;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HypeHubAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthenticationController : ControllerBase
{
    private readonly IMediator _mediator;

    public AuthenticationController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("Register")]
    public async Task<IActionResult> Register([FromBody] RegistrationCreateDTO registrationCreateDTO)
    {
        var result = await _mediator.Send(new RegisterAccountCommand(registrationCreateDTO));
        return Ok(result);
    }

    [HttpPost("Login")]
    public async Task<IActionResult> Login([FromBody] LoggingCreateDTO loggingCreateDTO)
    {
        var result = await _mediator.Send(new LoginAccountCommand(loggingCreateDTO));
        return Ok(result);
    }
}
