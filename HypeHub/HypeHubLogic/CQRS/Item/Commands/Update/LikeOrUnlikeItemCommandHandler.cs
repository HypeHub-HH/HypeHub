using AutoMapper;
using FluentValidation;
using HypeHubDAL.Exeptions;
using HypeHubDAL.Models.Relations;
using HypeHubDAL.Repositories;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.Account;
using HypeHubLogic.DTOs.AccountItemLike;
using HypeHubLogic.DTOs.AccountOutfitLike;
using MediatR;
using System.Security.Claims;

namespace HypeHubLogic.CQRS.Item.Commands.Update;
public class LikeOrUnlikeItemCommandHandler : IRequestHandler<LikeOrUnlikeItemCommand, List<AccountItemLikeReadDTO>>
{
    private readonly IAccountItemLikeRepository _likeRepository;
    private readonly IAccountRepository _accountRepository;
    private readonly IMapper _mapper;
    private readonly IValidator<AccountItemLikeCreateDTO> _validator;
    public LikeOrUnlikeItemCommandHandler(IAccountItemLikeRepository likeRepository, IAccountRepository accountRepository, IMapper mapper, IValidator<AccountItemLikeCreateDTO> validator)
    {
        _likeRepository = likeRepository;
        _accountRepository = accountRepository;
        _mapper = mapper;
        _validator = validator;
        _accountRepository = accountRepository;
    }
    public async Task<List<AccountItemLikeReadDTO>> Handle(LikeOrUnlikeItemCommand request, CancellationToken cancellationToken)
    {
        var accountId = Guid.Parse(request.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value);
        var accountItemLikeDTO = new AccountItemLikeCreateDTO(request.ItemId, accountId);
        var validationResult = await _validator.ValidateAsync(accountItemLikeDTO);
        if (!validationResult.IsValid) throw new ValidationFailedException("Validation failed", validationResult.Errors.Select(error => error.ErrorMessage));
        var accountItemLike = _mapper.Map<AccountItemLike>(accountItemLikeDTO);
        var searchedAccountItemLike = await _likeRepository.GetAsyncByAccountAndItemId(accountItemLike);
        if (searchedAccountItemLike != null) await _likeRepository.DeleteAsync(searchedAccountItemLike);
        else await _likeRepository.AddAsync(accountItemLike);
        var likes = await _likeRepository.GetItemLikesAsync(request.ItemId);
        var mappedLikes = _mapper.Map<List<AccountItemLikeReadDTO>>(likes);
        foreach (var like in mappedLikes)
        {
            var account = await _accountRepository.GetByIdAsync(like.AccountId);
            var mappedAccounts = _mapper.Map<AccountGeneralInfoReadDTO>(account);
            like.Account = mappedAccounts;
        }
        return mappedLikes;
    }
}
