using AutoMapper;
using HypeHubDAL.Exeptions;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.Item;
using MediatR;

namespace HypeHubLogic.CQRS.Account.Queries;
public class GetItemsFromAccountQueryHandler : IRequestHandler<GetItemsFromAccountQuery, List<ItemWithImagesAndLikesReadDTO>>
{
    private readonly IAccountRepository _accountRepository;
    private readonly IMapper _mapper;
    public GetItemsFromAccountQueryHandler(IAccountRepository accountRepository, IMapper mapper)
    {
        _accountRepository = accountRepository;
        _mapper = mapper;
    }
    public async Task<List<ItemWithImagesAndLikesReadDTO>> Handle(GetItemsFromAccountQuery request, CancellationToken cancellationToken)
    {
        var account = await _accountRepository.GetAccountWithItemsAsync(request.AccountId) ?? throw new NotFoundException($"There is no account with the given Id: {request.AccountId}.");
        var items = _mapper.Map<List<ItemWithImagesAndLikesReadDTO>>(account.Items);
        return items;
    }
}
