using HypeHubDAL.Models;
using HypeHubLogic.Services.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Google.Apis.Auth;
using HypeHubDAL.Repositories.Interfaces;

namespace HypeHubLogic.CQRS.Authentication.Commands.Post;
public class GoogleAuthenticateCommandHandler : IRequestHandler<GoogleAuthenticateCommand, GoogleAuthenticateResponse>
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly ITokenService _tokenService;
    private readonly IConfiguration _configuration;
    private readonly IAccountRepository _accountRepository;
    public GoogleAuthenticateCommandHandler(UserManager<ApplicationUser> userManager, ITokenService tokenService, IConfiguration configuration, IAccountRepository accountRepository)
    {
        _userManager = userManager;
        _tokenService = tokenService;
        _configuration = configuration;
        _accountRepository = accountRepository;
    }
    public async Task<GoogleAuthenticateResponse> Handle(GoogleAuthenticateCommand request, CancellationToken cancellationToken)
    {
        var payload = await GoogleJsonWebSignature.ValidateAsync(request.Token);
        var email = payload.Email;

        var managedUser = await _userManager.FindByEmailAsync(email);
        if (managedUser != null)
        {
            var roles = await _userManager.GetRolesAsync(managedUser);
            var accessToken = _tokenService.CreateToken(managedUser, roles);
            var refreshToken = _tokenService.GenerateRefreshToken();
            _ = int.TryParse(_configuration["JWT:RefreshTokenValidityInDays"], out int refreshTokenValidityInDays);
            managedUser.RefreshToken = refreshToken;
            managedUser.RefreshTokenExpiryTime = DateTime.Now.AddDays(refreshTokenValidityInDays);
            await _userManager.UpdateAsync(managedUser);

            var userId = Guid.Parse(managedUser.Id);
            var account = await _accountRepository.GetByIdAsync(userId);
            return new GoogleAuthenticateResponse() { AccountExist = true, AccountId = userId, UserName = account.Username, Email = managedUser.Email, AvatarURL = account.AvatarUrl, Token = accessToken, RefreshToken = refreshToken };
        }
        else
        {
            return new GoogleAuthenticateResponse() { AccountExist = false, Email = managedUser.Email };
        }
    }
}