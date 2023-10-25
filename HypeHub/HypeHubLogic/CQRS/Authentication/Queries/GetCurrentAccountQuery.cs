using HypeHubLogic.DTOs.Account;
using MediatR;

namespace HypeHubLogic.CQRS.Authentication.Queries;

public class GetCurrentAccountQuery : IRequest<AccountCurrentReadDTO>
{
    public string Token { get; init; }
    public GetCurrentAccountQuery(string token)
    {
        Token = token;
    }
}