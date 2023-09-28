using HypeHubLogic.DTOs.Account;
using MediatR;

namespace HypeHubLogic.CQRS.Account.Queries;

public class GetSearchedAccountsQuery : IRequest<List<AccountGeneralInfoReadDTO>>
{
    public string SearchedString { get; set; }

    public GetSearchedAccountsQuery(string searchedString)
    {
        SearchedString = searchedString;
    }
}
