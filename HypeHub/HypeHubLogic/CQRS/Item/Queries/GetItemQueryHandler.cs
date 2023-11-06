using AutoMapper;
using HypeHubDAL.Exeptions;
using HypeHubDAL.Models;
using HypeHubDAL.Repositories;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.Account;
using HypeHubLogic.DTOs.Item;
using MediatR;

namespace HypeHubLogic.CQRS.Item.Queries;
public class GetItemQueryHandler : IRequestHandler<GetItemQuery, ItemWithImagesAndLikesReadDTO>
{
    private readonly IItemRepository _itemRepository;
    private readonly IAccountRepository _accountRepository;
    private readonly IMapper _mapper;
    public GetItemQueryHandler(IItemRepository itemRepository, IMapper mapper, IAccountRepository accountRepository)
    {
        _itemRepository = itemRepository;
        _mapper = mapper;
        _accountRepository = accountRepository;
    }
    public async Task<ItemWithImagesAndLikesReadDTO> Handle(GetItemQuery request, CancellationToken cancellationToken)
    {
        var item = await _itemRepository.GetItemWithLikesAndImagesAsync(request.ItemId) ?? throw new NotFoundException($"There is no item with the given Id: {request.ItemId}.");
        var mappedItem = _mapper.Map<ItemWithImagesAndLikesReadDTO>(item);
        foreach (var like in mappedItem.Likes)
        {
            var account = await _accountRepository.GetByIdAsync(like.AccountId);
            var mappedAccounts = _mapper.Map<AccountGeneralInfoReadDTO>(account);
            like.Account = mappedAccounts;
        }
        return mappedItem;
    }
}