using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.CQRS.Account.Commands.Delete;
using HypeHubLogic.CQRS.Account.Queries;
using HypeHubLogic.CQRS.Authentication.Commands.Post;
using HypeHubLogic.CQRS.Item.Queries;
using HypeHubLogic.DTOs.Account;
using HypeHubLogic.DTOs.Registration;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HypeHubAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AccountController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAccount(Guid id)
        {
            var result = await _mediator.Send(new GetAccountQuery(id));
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
}
