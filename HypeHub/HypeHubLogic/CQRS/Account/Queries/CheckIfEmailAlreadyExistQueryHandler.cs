using HypeHubDAL.Models;
using HypeHubDAL.Repositories.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace HypeHubLogic.CQRS.Account.Queries;
public class CheckIfEmailAlreadyExistQueryHandler : IRequestHandler<CheckIfEmailAlreadyExistQuery, bool>
{
    private readonly UserManager<ApplicationUser> _userManager;
    public CheckIfEmailAlreadyExistQueryHandler(UserManager<ApplicationUser> userManager)
    {
        _userManager = userManager;
    }
    public async Task<bool> Handle(CheckIfEmailAlreadyExistQuery request, CancellationToken cancellationToken)
    {
        var existUser = await _userManager.FindByEmailAsync(request.Email);
        return existUser != null;
    }
}