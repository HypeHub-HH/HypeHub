//using AutoMapper;
//using HypeHubDAL.Exeptions;
//using HypeHubDAL.Repositories.Interfaces;
//using HypeHubLogic.DTOs.Item;
//using MediatR;

//namespace HypeHubLogic.CQRS.Item.Queries;

//public class GetItemsFromAccountQueryHandler : IRequestHandler<GetItemsFromAccountQuery, List<ItemReadDTO>>
//{
//    private readonly IItemRepository _itemRepository;
//    private readonly IAccountRepository _accountRepository;
//    private readonly IMapper _mapper;

//    public GetItemsFromAccountQueryHandler(IItemRepository itemRepository, IAccountRepository accountRepository, IMapper mapper)
//    {
//        _itemRepository = itemRepository;
//        _accountRepository = accountRepository;
//        _mapper = mapper;
//    }

//    public async Task<List<ItemReadDTO>> Handle(GetItemsFromAccountQuery request, CancellationToken cancellationToken)
//    {
//        var account = await _accountRepository.GetByIdAsync(request.AccountID) ?? throw new NotFoundException($"There is no account with the given Id: {request.AccountID}.");
//        var items  = await _itemRepository.GetAllAsync
//        throw new NotImplementedException();
//    }
//}
