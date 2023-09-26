using HypeHubLogic.CQRS.Item.Commands.Delete;
using HypeHubLogic.CQRS.Item.Commands.Post;
using HypeHubLogic.CQRS.Item.Commands.Update;
using HypeHubLogic.CQRS.Item.Queries;
using HypeHubLogic.DTOs.AccountItemLike;
using HypeHubLogic.DTOs.Item;
using HypeHubLogic.DTOs.ItemImage;
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

    [HttpGet("{id}")]
    public async Task<IActionResult> GetItem(Guid id)
    {
        var result = await _mediator.Send(new GetItemQuery(id));
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> CreateItem([FromBody] ItemCreateDTO item)
    {
        var result = await _mediator.Send(new CreateItemCommand(item));
        return CreatedAtAction(nameof(GetItem), new { id = result.Id }, result);
    }

    [HttpPost]
    public async Task<IActionResult> AddPhotoToItem([FromBody] ItemImageCreateDTO item)
    {
        await _mediator.Send(new AddPhotoToItemCommand(item));
        return Ok();
    }

    [HttpPut()]
    public async Task<IActionResult> UpdateItem([FromBody] ItemUpdateDTO item)
    {
        var result = await _mediator.Send(new UpdateItemCommand(item));
        return CreatedAtAction(nameof(GetItem), new { id = result.Id }, result);
    }

    [HttpPut("{id}/like")]
    public async Task<IActionResult> LikeOrUnlikeItem([FromBody] AccountItemLikeCreateDTO accountItemLike)
    {
        await _mediator.Send(new LikeOrUnlikeItemCommand(accountItemLike));
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteItem(Guid id)
    {
        await _mediator.Send(new DeleteItemCommand(id));
        return NoContent();
    }
}
