using HypeHubLogic.CQRS.Outfit.Commands.Delete;
using HypeHubLogic.CQRS.Outfit.Commands.Post;
using HypeHubLogic.CQRS.Outfit.Commands.Update;
using HypeHubLogic.CQRS.Outfit.Queries;
using HypeHubLogic.DTOs.Outfit;
using HypeHubLogic.DTOs.OutfitImage;
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

    [HttpGet("{outfitId}/Images")]
    public async Task<IActionResult> GetOutfitImages(Guid outfitId)
    {
        var result = await _mediator.Send(new GetOutfitImagesQuery(outfitId));
        return Ok(result);
    }

    [HttpGet("{outfitId}/Images/{Id}")]
    public async Task<IActionResult> GetOutfitImage(Guid Id)
    {
        var result = await _mediator.Send(new GetOutfitImageQuery(Id));
        return Ok(result);
    }

    [HttpPost("{outfitId}/Images")]
    public async Task<IActionResult> CreateImage([FromBody] OutfitImageCreateDTO outfitImage)
    {
        var result = await _mediator.Send(new CreateOutfitImageCommand(outfitImage));
        return CreatedAtAction(nameof(GetOutfitImage), new { id = result.Id }, result);
    }

    [HttpDelete("{outfitId}/Images/{id}")]
    public async Task<IActionResult> DeleteImage(Guid id)
    {
        await _mediator.Send(new DeleteOutfitImageCommand(id));
        return NoContent();
    }
}
