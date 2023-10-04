using HypeHubDAL.Models;
using HypeHubLogic.CQRS.Authentication.Commands.Post;
using HypeHubLogic.DTOs.Logging;
using HypeHubLogic.DTOs.Registration;
using MediatR;
using Microsoft.AspNetCore.Authorization;
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

    [HttpPost("RefreshToken")]
    public async Task<IActionResult> RefreshToken([FromBody] Token token)
    {
        var result = await _mediator.Send(new RefreshTokenCommand(token));
        return Ok(result);
    }

    [HttpPost("RevokeToken/{username}")]
    [Authorize]
    public async Task<IActionResult> RevokeToken(string username)
    {
        await _mediator.Send(new RevokeTokenCommand(username));
        return NoContent();
    }
}
