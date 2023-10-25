using HypeHubDAL.Exeptions;
using HypeHubDAL.Models;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.Account;
using HypeHubLogic.Services.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace HypeHubLogic.CQRS.Authentication.Queries;

public class GetCurrentAccountQueryHandler : IRequestHandler<GetCurrentAccountQuery, AccountCurrentReadDTO>
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly IAccountRepository _accountRepository;
    private readonly ITokenService _tokenService;
    public GetCurrentAccountQueryHandler(UserManager<ApplicationUser> userManager, IAccountRepository accountRepository, ITokenService tokenService)
    {
        _userManager = userManager;
        _accountRepository = accountRepository;
        _tokenService = tokenService;
    }
    public async Task<AccountCurrentReadDTO> Handle(GetCurrentAccountQuery request, CancellationToken cancellationToken)
    {
        var token = request.Token.Split(" ").Last().ToString();
        var principal = _tokenService.GetPrincipalFromExpiredToken(token) ?? throw new BadRequestException($"Invalid access token.");

        var id = principal.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value;

        var managedUser = await _userManager.FindByIdAsync(id) ?? throw new WrongCredentialsException($"There is no account with the given id: {id}.");
        var roles = await _userManager.GetRolesAsync(managedUser);

        var guidId = Guid.Parse(id);
        var account = await _accountRepository.GetByIdAsync(guidId);

        return new AccountCurrentReadDTO() { AccountId = guidId, UserName = managedUser.UserName, Email = managedUser.Email, IsPrivate = account.IsPrivate, AvatarURL = account.AvatarUrl, Roles = roles };
    }
}