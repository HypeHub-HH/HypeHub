using HypeHubDAL.Exeptions;
using HypeHubDAL.Models;
using HypeHubLogic.Services.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace HypeHubLogic.CQRS.Authentication.Commands.Post;
public class RefreshTokenCommandHandler : IRequestHandler<RefreshTokenCommand, Token>
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly ITokenService _tokenService;
    public RefreshTokenCommandHandler(UserManager<ApplicationUser> userManager, ITokenService tokenService)
    {
        _userManager = userManager;
        _tokenService = tokenService;
    }
    public async Task<Token> Handle(RefreshTokenCommand request, CancellationToken cancellationToken)
    {
        var principal = _tokenService.GetPrincipalFromExpiredToken(request.Token.AccessToken) ?? throw new BadRequestException($"Invalid access token.");
        var id = principal.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value;
        var managedUser = await _userManager.FindByIdAsync(id) ?? throw new WrongCredentialsException($"There is no account with the given id: {id}.");
        if (managedUser.RefreshToken != request.Token.RefreshToken || managedUser.RefreshTokenExpiryTime <= DateTime.Now) throw new BadRequestException($"Invalid refresh token.");
        var roles = await _userManager.GetRolesAsync(managedUser);
        var accessToken = _tokenService.CreateToken(managedUser, roles);
        var refreshToken = _tokenService.GenerateRefreshToken();
        managedUser.RefreshToken = refreshToken;
        await _userManager.UpdateAsync(managedUser);
        return new Token() { AccessToken = accessToken, RefreshToken = refreshToken };
    }
}