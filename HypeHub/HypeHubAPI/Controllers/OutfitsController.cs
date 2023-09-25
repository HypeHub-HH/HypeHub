using HypeHubLogic.CQRS.Outfit.Commands.Delete;
using HypeHubLogic.CQRS.Outfit.Commands.Post;
using HypeHubLogic.CQRS.Outfit.Commands.Update;
using HypeHubLogic.CQRS.Outfit.Queries;
using HypeHubLogic.DTOs.Outfit;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HypeHubAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OutfitsController : ControllerBase
{
    private readonly IMediator _mediator;

    public OutfitsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetOutfit(Guid id)
    {
        var result = await _mediator.Send(new GetOutfitQuery(id));
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> CreateOutfit([FromBody] OutfitCreateDTO outfit)
    {
        var result = await _mediator.Send(new CreateOutfitCommand(outfit));
        return CreatedAtAction(nameof(GetOutfit), new { id = result.Id }, result);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateOutfit([FromBody] OutfitUpdateDTO outfit)
    {
        var result = await _mediator.Send(new UpdateOutfitCommand(outfit));
        return CreatedAtAction(nameof(GetOutfit), new { id = result.Id }, result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteOutfit(Guid id)
    {
        await _mediator.Send(new DeleteOutfitCommand(id));
        return NoContent();
    }
}
