using AutoMapper;
using HypeHubDAL.Exeptions;
using HypeHubDAL.Repositories;
using HypeHubDAL.Repositories.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;

namespace HypeHubLogic.CQRS.Item.Commands.Post;

public class LikeOrUnlikeItemCommandHandler : IRequestHandler<LikeOrUnlikeItemCommand>
{
    private readonly IAccountItemLikeRepository _likeRepository;
    private readonly IItemRepository _itemRepository;
    private readonly IAccountRepository _accountRepository;
    private readonly IMapper _mapper;

    public LikeOrUnlikeItemCommandHandler(IAccountItemLikeRepository likeRepository, IItemRepository itemRepository, IAccountRepository accountRepository, IMapper mapper)
    {
        _likeRepository = likeRepository;
        _itemRepository = itemRepository;
        _accountRepository = accountRepository;
        _mapper = mapper;
    }

    public async Task Handle(LikeOrUnlikeItemCommand request, CancellationToken cancellationToken)
    {
        if (await _accountRepository.GetByIdAsync(request.AccountItemLike.AccountId) == null)
        {
            throw new BadRequestException($"User with id:{request.AccountItemLike.AccountId} does not exist");
        }
        if(await _itemRepository.GetByIdAsync(request.AccountItemLike.ItemId) == null)
        {
            throw new BadRequestException($"Item with id:{request.AccountItemLike.AccountId} does not exist");
        }
        var accountItemLike = _mapper.Map<HypeHubDAL.Models.Relations.AccountItemLike>(request.AccountItemLike);
        var searchedAccountItemLike = await _likeRepository.GetAsyncByAccountAndItemId(accountItemLike);
        if (searchedAccountItemLike != null)
        {
            await _likeRepository.DeleteAsync(searchedAccountItemLike);   
        }
        else
        {
            await _likeRepository.AddAsync(accountItemLike);
        }
    }
}
