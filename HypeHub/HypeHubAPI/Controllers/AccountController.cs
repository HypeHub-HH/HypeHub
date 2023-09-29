using HypeHubLogic.CQRS.Account.Commands.Delete;
using HypeHubLogic.CQRS.Account.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HypeHubAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AccountController : ControllerBase
{
    private readonly IMediator _mediator;

    public AccountController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("{id}/Outfits")]
    public async Task<IActionResult> GetAccountWithOutfits(Guid id)
    {
        var result = await _mediator.Send(new GetAccountWithOutfitsQuery(id));
        return Ok(result);
    }

    [HttpGet("Search")]
    public async Task<IActionResult> GetSearchedAccounts([FromQuery] string searchedUsername)
    {
        var result = await _mediator.Send(new GetSearchedAccountsQuery(searchedUsername));
        return Ok(result);
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteAccount([FromBody] Guid id)
    {
        await _mediator.Send(new DeleteAccountCommand(id));
        return NoContent();
    }
}

