using HypeHubLogic.CQRS.Account.Commands.Delete;
using HypeHubLogic.CQRS.Account.Queries;
using HypeHubLogic.DTOs.Exception;
using HypeHubLogic.DTOs.Outfit;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HypeHubAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AccountController : ControllerBase
{
    private readonly IMediator _mediator;

    public AccountController(IMediator mediator)
    {
        _mediator = mediator;
    }

    #region Endpoint Description
    /// <summary>
    /// Retrieves an account with associated outfits information by its unique identifier (ID).
    /// </summary>
    /// <param name="id">The unique identifier of the account to be retrieved.</param>
    /// <returns>
    ///   Returns an HTTP 200 (OK) response with the account details, along with its associated outfits information.
    /// </returns>
    /// <remarks>
    ///   This endpoint allows you to retrieve an account with its associated outfit information
    ///   by providing the unique identifier ("id") of the account as part of the URL route. After a successful retrieval,
    ///   a response with an HTTP 200 (OK) status code will be returned, and it will contain comprehensive information about
    ///   the account, including its associated outfits.
    /// </remarks>
    /// <param name="id">A GUID representing the unique identifier of the account to be retrieved.</param>
    /// <response code="200">The account with the specified "id" and its associated information was successfully retrieved.</response>
    /// <response code="404">The account with the specified "id" was not found.</response>
    [ProducesResponseType(typeof(OutfitWithAccountAndImagesAndLikesAndItemsReadDTO), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ExceptionOccuredReadDTO), StatusCodes.Status404NotFound)]
    #endregion
    [HttpGet("{id}/Outfits")]
    public async Task<IActionResult> GetAccountWithOutfits(Guid id)
    {
        var result = await _mediator.Send(new GetAccountWithOutfitsQuery(id));
        return Ok(result);
    }

    #region Endpoint Description
    /// <summary>
    /// Search for usernames.
    /// </summary>
    /// <param name="searchedUsername">The username to be searched.</param>
    /// <returns>
    /// Returns HTTP 200 (Ok) response after a successful search for username.
    /// </returns>
    /// <remarks>
    ///   This endpoint allows you to search for usernames. To use this endpoint,
    ///   provide the "searchedUsername" as part of the URL route. Response with an HTTP 200 (Ok) status code will be returned upon
    ///   successful serching.
    /// </remarks>
    /// <param name="searchedUsername">A string representing the searched usernames of the accounts.</param>
    /// <response code="200">Returns a list of usernames after a successful search that matches a serched username.</response>
    [ProducesResponseType(StatusCodes.Status200OK)]
    #endregion
    [HttpGet("Search")]
    public async Task<IActionResult> GetSearchedAccounts([FromQuery] string searchedUsername)
    {
        var result = await _mediator.Send(new GetSearchedAccountsQuery(searchedUsername));
        return Ok(result);
    }

    #region Endpoint Description
    /// <summary>
    /// Checks a specific username.
    /// </summary>
    /// <param name="username">The unique username of the account to be checked.</param>
    /// <returns>
    /// Returns HTTP 200 (Ok) response after successful username check.
    /// </returns>
    /// <remarks>
    ///   This endpoint allows you to check a specific username. To use this endpoint,
    ///   provide the "username" as part of the URL route. Response with an HTTP 200 (Ok) status code will be returned upon
    ///   successful checking.
    /// </remarks>
    /// <param name="username">A string representing the unique username of the account.</param>
    /// <response code="200">Returns a boolean value after successfully checking if the username exists.</response>
    [ProducesResponseType(StatusCodes.Status200OK)]
    #endregion
    [HttpGet("Username")]
    public async Task<IActionResult> CheckIfUsernameExist([FromQuery] string username)
    {
        var result = await _mediator.Send(new CheckIfUsernameAlreadyExistQuery(username));
        return Ok(result);
    }

    #region Endpoint Description
    /// <summary>
    /// Checks a specific email.
    /// </summary>
    /// <param name="email">The unique email of the account to be checked.</param>
    /// <returns>
    /// Returns HTTP 200 (Ok) response after successful email check.
    /// </returns>
    /// <remarks>
    ///   This endpoint allows you to check a specific email. To use this endpoint,
    ///   provide the "email" as part of the URL route. Response with an HTTP 200 (Ok) status code will be returned upon
    ///   successful checking.
    /// </remarks>
    /// <param name="email">A string representing the unique email of the account.</param>
    /// <response code="200">Returns a boolean value after successfully checking if the email exists.</response>
    [ProducesResponseType(StatusCodes.Status200OK)]
    #endregion
    [HttpGet("Email")]
    public async Task<IActionResult> CheckIfEmailExist([FromQuery] string email)
    {
        var result = await _mediator.Send(new CheckIfEmailAlreadyExistQuery(email));
        return Ok(result);
    }

    #region Endpoint Description
    /// <summary>
    /// Deletes a specific account.
    /// </summary>
    /// <param name="id">The unique identifier of the account to be deleted.</param>
    /// <returns>
    ///   Returns an HTTP 204 (No Content) response upon successful deletion of the account.
    /// </returns>
    /// <remarks>
    ///   This endpoint allows you to delete a specific account. To use this endpoint,
    ///   provide the "id" as part of the URL route. Ensure you are authenticated with a valid authorization
    ///   token, as this endpoint is secured with the "Authorize" attribute. The account with the specified "id"
    ///   will be deleted, and a response with an HTTP 204 (No Content) status code will be returned upon
    ///   successful deletion.
    /// </remarks>
    /// <param name="id">A GUID representing the unique identifier of the account to be deleted.</param>
    /// <response code="204">The account with the specified "id" was successfully deleted, and no content is returned.</response>
    /// <response code="401">User was unauthorized or JWT was invalid</response>
    /// <response code="404">The account with the specified "id" was not found.</response>
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ExceptionOccuredReadDTO), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ExceptionOccuredReadDTO), StatusCodes.Status404NotFound)]
    #endregion
    [HttpDelete]
    public async Task<IActionResult> DeleteAccount([FromBody] Guid id)
    {
        await _mediator.Send(new DeleteAccountCommand(id));
        return NoContent();
    }
}

