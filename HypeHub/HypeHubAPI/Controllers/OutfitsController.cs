using HypeHubLogic.CQRS.Outfit.Commands.Delete;
using HypeHubLogic.CQRS.Outfit.Commands.Post;
using HypeHubLogic.CQRS.Outfit.Commands.Update;
using HypeHubLogic.CQRS.Outfit.Queries;
using HypeHubLogic.DTOs.AccountOutfitLike;
using HypeHubLogic.DTOs.Outfit;
using HypeHubLogic.DTOs.OutfitImage;
using MediatR;
using Microsoft.AspNetCore.Authorization;
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
    [Authorize]
    public async Task<IActionResult> GetOutfit(Guid id)
    {
        var result = await _mediator.Send(new GetOutfitQuery(id));
        return Ok(result);
    }

    [HttpGet("{id}/AllInformation")]
    public async Task<IActionResult> GetOutfitWithAccountAndLikesAndImagesAndItems(Guid id)
    {
        var result = await _mediator.Send(new GetOutfitWithAccountAndLikesAndImagesAndItemsQuery(id));
        return Ok(result);
    }

    [HttpGet("Latest")]
    public async Task<IActionResult> GetLatestOutfits([FromQuery] int page, int count)
    {
        var result = await _mediator.Send(new GetLatestOutfitsQuery(page, count));
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

    [HttpPut("Like")]
    public async Task<IActionResult> LikeOrUnlikeOutfit([FromBody] AccountOutfitLikeCreateDTO accountOutfitLike)
    {
        await _mediator.Send(new LikeOrUnlikeOutfitCommand(accountOutfitLike));
        return Ok();
    }

    [HttpGet("{outfitId}/Images")]
    public async Task<IActionResult> GetOutfitImages(Guid outfitId)
    {
        var result = await _mediator.Send(new GetOutfitImagesQuery(outfitId));
        return Ok(result);
    }

    [HttpGet("Images/{Id}")]
    public async Task<IActionResult> GetOutfitImage(Guid Id)
    {
        var result = await _mediator.Send(new GetOutfitImageQuery(Id));
        return Ok(result);
    }

    [HttpPost("{outfitId}/Images")]
    public async Task<IActionResult> CreateImage([FromBody] OutfitImageCreateDTO outfitImage)
    {
        var result = await _mediator.Send(new CreateOutfitImageCommand(outfitImage));
        return CreatedAtAction(nameof(GetOutfitImage), new { outfitId = result.OutfitId, id = result.Id }, result);
    }

    [HttpDelete("Images/{id}")]
    public async Task<IActionResult> DeleteImage(Guid id)
    {
        await _mediator.Send(new DeleteOutfitImageCommand(id));
        return NoContent();
    }
}
