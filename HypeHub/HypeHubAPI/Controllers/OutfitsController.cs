using HypeHubDAL.Models;
using HypeHubDAL.Models.Relations;
using HypeHubLogic.CQRS.Outfit.Commands.Delete;
using HypeHubLogic.CQRS.Outfit.Commands.Post;
using HypeHubLogic.CQRS.Outfit.Commands.Update;
using HypeHubLogic.CQRS.Outfit.Queries;
using HypeHubLogic.DTOs.Exception;
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

    #region Endpoint Description
    /// <summary>
    /// Retrieves an outfit by its unique identifier (ID).
    /// </summary>
    /// <param name="id">The unique identifier of the outfit to be retrieved.</param>
    /// <returns>
    ///   Returns an HTTP 200 (OK) response with the outfit details associated with the specified ID.
    /// </returns>
    /// <remarks>
    ///   This endpoint allows you to retrieve outfit details by providing the unique identifier ("id") of the outfit
    ///   as part of the URL route. After a successful retrieval, a response with an HTTP 200 (OK) status code will be
    ///   returned, and it will contain the outfit details, such as its name, description, and other attributes.
    /// </remarks>
    /// <response code="200">The outfit with the specified "id" was successfully retrieved.</response>
    /// <response code="404">The outfit with the specified "id" was not found.</response>
    [ProducesResponseType(typeof(OutfitGenerallReadDTO), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ExceptionOccuredReadDTO), StatusCodes.Status404NotFound)]
    #endregion
    [HttpGet("{id}")]
    public async Task<IActionResult> GetOutfit(Guid id)
    {
        var result = await _mediator.Send(new GetOutfitQuery(id));
        return Ok(result);
    }

    #region Endpoint Description
    /// <summary>
    /// Retrieves an outfit with associated account information, likes, images, and items by its unique identifier (ID).
    /// </summary>
    /// <param name="id">The unique identifier of the outfit to be retrieved.</param>
    /// <returns>
    ///   Returns an HTTP 200 (OK) response with the outfit details, along with its associated account information,
    ///   likes, images, and items, all associated with the specified ID.
    /// </returns>
    /// <remarks>
    ///   This endpoint allows you to retrieve an outfit with its associated account information, likes, images, and items
    ///   by providing the unique identifier ("id") of the outfit as part of the URL route. After a successful retrieval,
    ///   a response with an HTTP 200 (OK) status code will be returned, and it will contain comprehensive information about
    ///   the outfit, including its associated account, likes, images, and items.
    /// </remarks>
    /// <response code="200">The outfit with the specified "id" and its associated information was successfully retrieved.</response>
    /// <response code="404">The outfit with the specified "id" was not found.</response>
    [ProducesResponseType(typeof(OutfitWithAccountAndImagesAndLikesAndItemsReadDTO), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ExceptionOccuredReadDTO), StatusCodes.Status404NotFound)]
    #endregion
    [HttpGet("{id}/AllInformation")]
    public async Task<IActionResult> GetOutfitWithAccountAndLikesAndImagesAndItems(Guid id)
    {
        var result = await _mediator.Send(new GetOutfitWithAccountAndLikesAndImagesAndItemsQuery(id));
        return Ok(result);
    }

    #region Endpoint Description
    /// <summary>
    /// Retrieves the latest outfits with pagination.
    /// </summary>
    /// <param name="page">The page number for pagination (starting from 1).</param>
    /// <param name="pageSize">The number of outfits to retrieve on each page.</param>
    /// <returns>
    ///   Returns an HTTP 200 (OK) response with the latest outfits for the specified page and count.
    /// </returns>
    /// <remarks>
    ///   This endpoint allows you to retrieve the latest outfits with pagination. Provide the "page" and "pageSize"
    ///   parameters in the query string to control which page of outfits to retrieve and how many outfits to include
    ///   on each page. After a successful retrieval, a response with an HTTP 200 (OK) status code will be returned,
    ///   containing the latest outfits according to the specified page and pageSize.
    /// </remarks>
    /// <response code="200">The latest outfits for the specified page and pageSize were successfully retrieved.</response>
    /// <response code="400">The pagination parameters are invalid or out of range.</response>
    [ProducesResponseType(typeof(List<OutfitWithAccountAndImagesAndLikesReadDTO>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ExceptionOccuredReadDTO), StatusCodes.Status400BadRequest)]
    #endregion
    [HttpGet("Latest")]
    public async Task<IActionResult> GetLatestOutfits([FromQuery] int page, int pageSize)
    {
        var result = await _mediator.Send(new GetLatestOutfitsQuery(page, pageSize));
        return Ok(result);
    }

    #region Endpoint Description
    /// <summary>
    /// Creates a new outfit.
    /// </summary>
    /// <param name="outfit">Data for creating a new outfit.</param>
    /// <returns>
    ///   Returns an HTTP 201 (Created) response upon successful creation of a new outfit, along with the outfit details.
    /// </returns>
    /// <remarks>
    ///   This endpoint allows you to create a new outfit by providing the necessary outfit data in the request body using
    ///   the JSON format. To use this endpoint, ensure that you are authenticated with a valid authorization token, as it is
    ///   secured with the "Authorize" attribute. After successful creation, a response with an HTTP 201 (Created) status code
    ///   will be returned, and it will include the details of the newly created outfit.
    /// </remarks>
    /// <response code="201">The new outfit was successfully created, and its details are returned.</response>
    /// <response code="400">The creation request was invalid or the outfit data is incomplete.</response>
    /// <response code="401">User was unauthorized or JWT was invalid</response>
    /// <response code="500">The error occurred on the server side.</response>
    [ProducesResponseType(typeof(OutfitGenerallReadDTO), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ExceptionOccuredReadDTO), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ExceptionOccuredReadDTO), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ExceptionOccuredReadDTO), StatusCodes.Status500InternalServerError)]
    #endregion
    [HttpPost]
    [Authorize]
    public async Task<IActionResult> CreateOutfit([FromBody] OutfitCreateDTO outfit)
    {
        var result = await _mediator.Send(new CreateOutfitCommand(outfit, HttpContext.User.Claims));
        return CreatedAtAction(nameof(GetOutfit), new { id = result.Id }, result);
    }

    #region Endpoint Description
    /// <summary>
    /// Updates an existing outfit.
    /// </summary>
    /// <param name="outfit">Data for updating an existing outfit.</param>
    /// <returns>
    ///   Returns an HTTP 201 (Created) response upon successful update of an outfit, along with the updated outfit details.
    /// </returns>
    /// <remarks>
    ///   This endpoint allows you to update an existing outfit by providing the necessary outfit data in the request body using
    ///   the JSON format. To use this endpoint, ensure that you are authenticated with a valid authorization token, as it is
    ///   secured with the "Authorize" attribute. After successful update, a response with an HTTP 201 (Created) status code
    ///   will be returned, and it will include the details of the updated outfit.
    /// </remarks>
    /// <response code="201">The outfit was successfully updated, and its updated details are returned.</response>
    /// <response code="400">The update request was invalid or the outfit data is incomplete.</response>
    /// <response code="401">User was unauthorized or JWT was invalid</response>
    [ProducesResponseType(typeof(OutfitGenerallReadDTO), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ExceptionOccuredReadDTO), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ExceptionOccuredReadDTO), StatusCodes.Status401Unauthorized)]
    #endregion
    [HttpPut]
    [Authorize]
    public async Task<IActionResult> UpdateOutfit([FromBody] OutfitUpdateDTO outfit)
    {
        var result = await _mediator.Send(new UpdateOutfitCommand(outfit, HttpContext.User.Claims));
        return CreatedAtAction(nameof(GetOutfit), new { id = result.Id }, result);
    }

    #region Endpoint Description
    /// <summary>
    /// Deletes an existing outfit by its unique identifier (ID).
    /// </summary>
    /// <param name="id">The unique identifier of the outfit to be deleted.</param>
    /// <returns>
    ///   Returns an HTTP 204 (No Content) response upon successful deletion of the outfit.
    /// </returns>
    /// <remarks>
    ///   This endpoint allows you to delete an existing outfit by providing the unique identifier ("id") of the outfit
    ///   as part of the URL route. To use this endpoint, ensure that you are authenticated with a valid authorization token,
    ///   as it is secured with the "Authorize" attribute. After successful deletion, a response with an HTTP 204 (No Content)
    ///   status code will be returned.
    /// </remarks>
    /// <response code="204">The outfit with the specified "id" was successfully deleted, and no content is returned.</response>
    /// <response code="401">User was unauthorized or JWT was invalid</response>
    /// <response code="404">The outfit with the specified "id" was not found.</response>
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ExceptionOccuredReadDTO), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ExceptionOccuredReadDTO), StatusCodes.Status404NotFound)]
    #endregion
    [HttpDelete("{id}")]
    [Authorize]
    public async Task<IActionResult> DeleteOutfit(Guid id)
    {
        await _mediator.Send(new DeleteOutfitCommand(id, HttpContext.User.Claims));
        return NoContent();
    }

    #region Endpoint Description
    /// <summary>
    /// Likes or unlikes an existing outfit.
    /// </summary>
    /// <param name="outfitId">The unique identifier of the outfit to like or unlike.</param>
    /// <returns>
    ///   Returns an HTTP 200 (OK) response upon successful liking or unliking of the outfit with current outfit likes.
    /// </returns>
    /// <remarks>
    ///   This endpoint allows you to like or unlike an existing outfit by providing the unique identifier ("outfitId") of
    ///   the outfit as part of the URL route. To use this endpoint, ensure that you are authenticated with
    ///   a valid authorization token, as it is secured with the "Authorize" attribute. After successful liking or unliking,
    ///   a response with an HTTP 200 (OK) status code will be returned.
    /// </remarks>
    /// <response code="200">The item with the specified "id" was successfully liked or unliked.</response>
    /// <response code="401">User was unauthorized or JWT was invalid</response>
    /// <response code="404">The item with the specified "id" was not found.</response>
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ExceptionOccuredReadDTO), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ExceptionOccuredReadDTO), StatusCodes.Status404NotFound)]
    #endregion
    [HttpPut("Like/{outfitId}")]
    [Authorize]
    public async Task<IActionResult> LikeOrUnlikeOutfit(Guid outfitId)
    {
        var result = await _mediator.Send(new LikeOrUnlikeOutfitCommand(outfitId, HttpContext.User.Claims));
        return Ok(result);
    }

    #region Endpoint Description
    /// <summary>
    ///   Add ann item to the outfit.
    /// </summary>
    /// <param name="outfitItem">Data for adding an item to the outfit</param>
    /// <returns>
    ///   Returns an HTTP 200 (Ok) response upon successfully adding an item to the outfit.
    /// </returns>
    /// <remarks>
    ///   This endpoint allows you to add an item to the outfit by providing the necessary data in
    ///   the request body using the JSON format. To use this endpoint, ensure that you are authenticated with a valid
    ///   authorization token, as it is secured with the "Authorize" attribute. After successful creation, a response with
    ///   an HTTP 200 (Ok) status code will be returned, and it will include the details of the added outfit item.
    /// </remarks>
    /// <response code="200">The item was successfully added, and its details are returned.</response>
    /// <response code="400">The adding request was invalid or the outfitItem data is incomplete.</response>
    /// <response code="401">User was unauthorized or JWT was invalid</response>
    /// <response code="500">The error occurred on the server side.</response>
    [ProducesResponseType(typeof(OutfitItem), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ExceptionOccuredReadDTO), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ExceptionOccuredReadDTO), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ExceptionOccuredReadDTO), StatusCodes.Status500InternalServerError)]
    #endregion
    [HttpPost("{outfitId}/Items")]
    [Authorize]
    public async Task<IActionResult> AddItemToOutfit([FromBody] OutfitItem outfitItem)
    {
        var result = await _mediator.Send(new AddItemToOutfitCommand(outfitItem, HttpContext.User.Claims));
        return Ok(result);
    }

    #region Endpoint Description
    /// <summary>
    /// Removes the item from the outfit.
    /// </summary>
    /// <param name="outfitItem">Data to remove the item from the outfit</param>
    /// <returns>
    ///   Returns an HTTP 204 (no content) response after successfully removing the item from an outfit.
    /// </returns>
    /// <remarks>
    ///   This endpoint allows you to remove the item from the outfit by providing the necessary data in
    ///   the request body using the JSON format. To use this endpoint, ensure that you are authenticated with a valid authorization
    ///   token, as it is secured with the "Authorize" attribute. After successful removal, a response with an HTTP 204 (No Content)
    ///   status code will be returned.
    /// </remarks>
    /// <response code="204">The item was successfully removed, and no content is returned.</response>
    /// <response code="400">The removing request was invalid or the outfitItem data is incomplete.</response>
    /// <response code="401">User was unauthorized or JWT was invalid</response>
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ExceptionOccuredReadDTO), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ExceptionOccuredReadDTO), StatusCodes.Status401Unauthorized)]
    #endregion
    [HttpDelete("{outfitId}/Items")]
    [Authorize]
    public async Task<IActionResult> RemoveItemFromOutfit([FromBody] OutfitItem outfitItem)
    {
        await _mediator.Send(new RemoveItemFromOutfitCommand(outfitItem, HttpContext.User.Claims));
        return NoContent();
    }

    //#region Endpoint Description
    /// <summary>
    /// Retrieves images associated with an outfit by its unique identifier (ID).
    /// </summary>
    /// <param name="outfitId">The unique identifier of the outfit for which images are to be retrieved.</param>
    /// <returns>
    ///   Returns an HTTP 200 (OK) response with the images associated with the specified outfit.
    /// </returns>
    /// <remarks>
    ///   This endpoint allows you to retrieve images associated with an outfit by providing the unique identifier ("outfitId")
    ///   of the outfit as part of the URL route. After a successful retrieval, a response with an HTTP 200 (OK) status code
    ///   will be returned, and it will contain the images associated with the specified outfit.
    /// </remarks>
    /// <param name="outfitId">A GUID representing the unique identifier of the outfit for which images are to be retrieved.</param>
    /// <response code="200">The images associated with the specified outfit were successfully retrieved.</response>
    /// <response code="404">The outfit with the specified "outfitId" was not found, or there are no images associated with it.</response>
    //[ProducesResponseType(typeof(List<OutfitImageReadDTO>), StatusCodes.Status200OK)]
    //[ProducesResponseType(typeof(ExceptionOccuredReadDTO), StatusCodes.Status404NotFound)]
    //#endregion
    //[HttpGet("{outfitId}/Images")]
    //public async Task<IActionResult> GetOutfitImages(Guid outfitId)
    //{
    //    var result = await _mediator.Send(new GetOutfitImagesQuery(outfitId));
    //    return Ok(result);
    //}

    #region Endpoint Description
    /// <summary>
    /// Retrieves a specific image associated with an outfit by its unique identifier (ID).
    /// </summary>
    /// <param name="Id">The unique identifier of the image to be retrieved.</param>
    /// <returns>
    ///   Returns an HTTP 200 (OK) response with the image associated with the specified ID.
    /// </returns>
    /// <remarks>
    ///   This endpoint allows you to retrieve a specific image associated with an outfit by providing the unique identifier ("Id")
    ///   of the image as part of the URL route. After a successful retrieval, a response with an HTTP 200 (OK) status code will
    ///   be returned, and it will contain the image associated with the specified ID.
    /// </remarks>
    /// <response code="200">The image associated with the specified "Id" was successfully retrieved.</response>
    /// <response code="404">The image with the specified "Id" was not found.</response>
    [ProducesResponseType(typeof(OutfitImageReadDTO), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ExceptionOccuredReadDTO), StatusCodes.Status404NotFound)]
    #endregion
    [HttpGet("Images/{Id}")]
    public async Task<IActionResult> GetOutfitImage(Guid Id)
    {
        var result = await _mediator.Send(new GetOutfitImageQuery(Id));
        return Ok(result);
    }

    #region Endpoint Description
    /// <summary>
    /// Creates a new image associated with an outfit.
    /// </summary>
    /// <param name="outfitImage">Data for creating a new image associated with an outfit.</param>
    /// <returns>
    ///   Returns an HTTP 201 (Created) response upon successful creation of a new image, along with the image details.
    /// </returns>
    /// <remarks>
    ///   This endpoint allows you to create a new image associated with an outfit by providing the necessary image data in
    ///   the request body using the JSON format. To use this endpoint, ensure that you are authenticated with a valid
    ///   authorization token, as it is secured with the "Authorize" attribute. After successful creation, a response with
    ///   an HTTP 201 (Created) status code will be returned, and it will include the details of the newly created image.
    /// </remarks>
    /// <response code="201">The new image was successfully created, and its details are returned.</response>
    /// <response code="400">The creation request was invalid or the image data is incomplete.</response>
    /// <response code="401">User was unauthorized or JWT was invalid</response>
    /// <response code="500">The error occurred on the server side.</response>
    [ProducesResponseType(typeof(OutfitImageReadDTO), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ExceptionOccuredReadDTO), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ExceptionOccuredReadDTO), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ExceptionOccuredReadDTO), StatusCodes.Status500InternalServerError)]
    #endregion
    [HttpPost("Images")]
    [Authorize]
    public async Task<IActionResult> CreateImage([FromBody] OutfitImageCreateDTO outfitImage)
    {
        var result = await _mediator.Send(new CreateOutfitImageCommand(outfitImage, HttpContext.User.Claims));
        return CreatedAtAction(nameof(GetOutfitImage), new { outfitId = result.OutfitId, id = result.Id }, result);
    }

    #region Endpoint Description
    /// <summary>
    /// Deletes an image associated with an outfit by its unique identifier (ID).
    /// </summary>
    /// <param name="id">The unique identifier of the image to be deleted.</param>
    /// <returns>
    ///   Returns an HTTP 204 (No Content) response upon successful deletion of the image.
    /// </returns>
    /// <remarks>
    ///   This endpoint allows you to delete an image associated with an outfit by providing the unique identifier ("id") of
    ///   the image as part of the URL route. To use this endpoint, ensure that you are authenticated with a valid authorization
    ///   token, as it is secured with the "Authorize" attribute. After successful deletion, a response with an HTTP 204 (No Content)
    ///   status code will be returned.
    /// </remarks>
    /// <response code="204">The image with the specified "id" was successfully deleted, and no content is returned.</response>
    /// <response code="401">User was unauthorized or JWT was invalid</response>
    /// <response code="404">The image with the specified "id" was not found.</response>
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ExceptionOccuredReadDTO), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ExceptionOccuredReadDTO), StatusCodes.Status404NotFound)]
    #endregion
    [HttpDelete("Images/{id}")]
    [Authorize]
    public async Task<IActionResult> DeleteImage(Guid id)
    {
        await _mediator.Send(new DeleteOutfitImageCommand(id, HttpContext.User.Claims));
        return NoContent();
    }
}
