
using HypeHubDAL.Models;
using HypeHubLogic.CQRS.Item.Commands.Post;
using HypeHubLogic.CQRS.Item.Commands.Update;
using HypeHubLogic.CQRS.Item.Queries;
using HypeHubLogic.DTOs.Item;
using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace HypeHubAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ItemsController : ControllerBase
{
    private readonly IMediator _mediator;

    public ItemsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    // GET api/<ItemsController>/5
    [HttpGet("{id}")]
    public async Task<IActionResult> GetItem(Guid id)
    {
        var query = new GetItemQuery(id);
        var result = await _mediator.Send(query);
        if (result is null) return NotFound();
        return Ok(result);
    }

    // POST api/<ItemsController>
    [HttpPost]
    public async Task<IActionResult> CreateItem([FromBody] ItemCreateDTO item)
    {
        var command = new CreateItemCommand(item);
        var result = await _mediator.Send(command);
        return Ok(result);
    }

    // PUT api/<ItemsController>/5
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateItem(Guid id, [FromBody] ItemCreateDTO item)
    {
        var command = new UpdateItemCommand(item, id);
        var result = await _mediator.Send(command);
        return Ok(result);
    }


    // DELETE api/<ItemsController>/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteItem(int id)
    {
        return Ok();
    }
}
