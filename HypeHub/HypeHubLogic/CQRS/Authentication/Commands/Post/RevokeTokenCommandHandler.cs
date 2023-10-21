using HypeHubDAL.Exeptions;
using HypeHubDAL.Models;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace HypeHubLogic.CQRS.Authentication.Commands.Post;
public class RevokeTokenCommandHandler : IRequestHandler<RevokeTokenCommand>
{
    private readonly UserManager<ApplicationUser> _userManager;
    public RevokeTokenCommandHandler(UserManager<ApplicationUser> userManager)
    {
        _userManager = userManager;
    }
    public async Task Handle(RevokeTokenCommand request, CancellationToken cancellationToken)
    {
        var managedUser = await _userManager.FindByNameAsync(request.Username) ?? throw new WrongCredentialsException($"There is no account with the given username: {request.Username}.");
        managedUser.RefreshToken = null;
        await _userManager.UpdateAsync(managedUser);
    }
}