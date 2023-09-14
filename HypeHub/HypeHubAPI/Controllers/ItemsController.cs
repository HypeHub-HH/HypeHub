using HypeHubLogic.CQRS.Item.Commands.Post;
using HypeHubLogic.CQRS.Item.Queries;
using HypeHubLogic.DTOs.Item;
using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace HypeHubAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ItemsController : ControllerBase
{
    private readonly Mediator _mediator;

    public ItemsController(Mediator mediator)
    {
        _mediator = mediator;
    }

    // GET api/<ItemsController>/5
    [HttpGet("{id}")]
    public async Task<IActionResult> GetItem(Guid id)
    {
        var result = await _mediator.Send(new GetItemQuery(id));
        if (result is null) return NotFound();
        return Ok(result);
    }

    // POST api/<ItemsController>
    [HttpPost]
    public async Task<IActionResult> CreateItem([FromBody] ItemCreateDTO item)
    {
        var result = await _mediator.Send(new CreateItemCommand(item));
        return Ok();
    }

    // PUT api/<ItemsController>/5
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateItem([FromBody] ItemCreateDTO item)
    {
        return Ok();
    }

    // DELETE api/<ItemsController>/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteItem(int id)
    {
        return Ok();
    }
}
