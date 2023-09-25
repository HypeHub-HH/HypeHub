using HypeHubLogic.CQRS.Outfit.Commands.Delete;
using HypeHubLogic.CQRS.Outfit.Commands.Post;
using HypeHubLogic.CQRS.Outfit.Queries;
using HypeHubLogic.DTOs.OutfitImage;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HypeHubAPI.Controllers;

[Route("api/Outfits/{outfitId}/Images")]
[ApiController]
public class OutfitImagesController : ControllerBase
{
    private readonly IMediator _mediator;

    public OutfitImagesController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetOutfitImages(Guid outfitId)
    {
        var result = await _mediator.Send(new GetOutfitImagesQuery(outfitId));
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetImage(Guid outfitId, Guid id)
    {
        var result = await _mediator.Send(new GetOutfitImageQuery(outfitId, id));
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> CreateImage(Guid outfitId, [FromBody] OutfitImageCreateDTO outfitImage)
    {
        var result = await _mediator.Send(new CreateOutfitImageCommand(outfitId, outfitImage));
        return CreatedAtAction(nameof(GetImage), new { id = result.Id }, result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteImage(Guid outfitId, Guid id)
    {
        await _mediator.Send(new DeleteOutfitImageCommand(outfitId, id));
        return NoContent();
    }
}