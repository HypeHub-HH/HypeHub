using HypeHubLogic.CQRS.Item.Commands.Delete;
using HypeHubLogic.CQRS.Item.Commands.Post;
using HypeHubLogic.CQRS.Item.Commands.Update;
using HypeHubLogic.CQRS.Item.Queries;
using HypeHubLogic.DTOs.Item;
using HypeHubLogic.DTOs.ItemImage;
using MediatR;
using Microsoft.AspNetCore.Authorization;
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
    [Authorize]
    public async Task<IActionResult> CreateItem([FromBody] ItemCreateDTO item)
    {
        var result = await _mediator.Send(new CreateItemCommand(item, HttpContext.User.Claims));
        return CreatedAtAction(nameof(GetItem), new { id = result.Id }, result);
    }

    [HttpPut]
    [Authorize]
    public async Task<IActionResult> UpdateItem([FromBody] ItemUpdateDTO item)
    {
        var result = await _mediator.Send(new UpdateItemCommand(item, HttpContext.User.Claims));
        return CreatedAtAction(nameof(GetItem), new { id = result.Id }, result);
    }

    [HttpDelete("{id}")]
    [Authorize]
    public async Task<IActionResult> DeleteItem(Guid id)
    {
        await _mediator.Send(new DeleteItemCommand(id, HttpContext.User.Claims));
        return NoContent();
    }

    [HttpGet("{itemId}/Images")]
    public async Task<IActionResult> GetItemImages(Guid itemId)
    {
        var result = await _mediator.Send(new GetItemImagesQuery(itemId));
        return Ok(result);
    }

    [HttpGet("Images/{imageId}")]
    public async Task<IActionResult> GetItemImage(Guid imageId)
    {
        var result = await _mediator.Send(new GetItemImageQuery(imageId));
        return Ok(result);
    }

    [HttpPost("{itemId}/Images")]
    [Authorize]
    public async Task<IActionResult> CreateImage([FromBody] ItemImageCreateDTO item)
    {
        await _mediator.Send(new CreateItemImageCommand(item, HttpContext.User.Claims));
        return Ok();
    }

    [HttpDelete("Images/{imageId}")]
    [Authorize]
    public async Task<IActionResult> DeleteImage(Guid imageId)
    {
        await _mediator.Send(new DeleteItemImageCommand(imageId, HttpContext.User.Claims));
        return NoContent();
    }

    [HttpPut("{id}/like")]
    [Authorize]
    public async Task<IActionResult> LikeOrUnlikeItem([FromBody] Guid itemId)
    {
        await _mediator.Send(new LikeOrUnlikeItemCommand(itemId, HttpContext.User.Claims));
        return Ok();
    }
}
