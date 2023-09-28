using HypeHubDAL.Exeptions;
using HypeHubLogic.DTOs.Logging;
using HypeHubLogic.Services.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace HypeHubLogic.CQRS.Authentication.Commands.Post;

public class LoginAccountCommandHandler : IRequestHandler<LoginAccountCommand, LoggingReadDTO>
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly ITokenService _tokenService;

    public LoginAccountCommandHandler(UserManager<IdentityUser> userManager, ITokenService tokenService)
    {
        _userManager = userManager;
        _tokenService = tokenService;
    }

    public async Task<LoggingReadDTO> Handle(LoginAccountCommand request, CancellationToken cancellationToken)
    {
        var emailOrUserName = request.LoggingCreateDTO.EmailOrUsername;
        var password = request.LoggingCreateDTO.Password;
        var managedUser = await _userManager.FindByEmailAsync(emailOrUserName);
        managedUser ??= await _userManager.FindByNameAsync(emailOrUserName) ?? throw new WrongCredentialsException($"There is no account with the given credentials: {emailOrUserName}.");

        var isPasswordValid = await _userManager.CheckPasswordAsync(managedUser, password);
        if (!isPasswordValid) throw new WrongCredentialsException($"Wrong password.");

        var roles = await _userManager.GetRolesAsync(managedUser);

        var accessToken = _tokenService.CreateToken(managedUser, roles);

        return new LoggingReadDTO() { Token = accessToken };
    }
}