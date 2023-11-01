using AutoMapper;
using FluentValidation;
using HypeHubDAL.Exeptions;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.AccountOutfitLike;
using HypeHubDAL.Models.Relations;
using MediatR;
using System.Security.Claims;
using HypeHubLogic.DTOs.Account;

namespace HypeHubLogic.CQRS.Outfit.Commands.Update;
public class LikeOrUnlikeOutfitCommandHandler : IRequestHandler<LikeOrUnlikeOutfitCommand, List<AccountOutfitLikeReadDTO>>
{
    private readonly IAccountOutfitLikeRepository _likeRepository;
    private readonly IAccountRepository _accountRepository;
    private readonly IMapper _mapper;
    private readonly IValidator<AccountOutfitLikeCreateDTO> _validator;
    public LikeOrUnlikeOutfitCommandHandler(IAccountOutfitLikeRepository likeRepository, IAccountRepository accountRepository, IMapper mapper, IValidator<AccountOutfitLikeCreateDTO> validator)
    {
        _likeRepository = likeRepository;
        _accountRepository = accountRepository;
        _mapper = mapper;
        _validator = validator;
    }
    public async Task<List<AccountOutfitLikeReadDTO>> Handle(LikeOrUnlikeOutfitCommand request, CancellationToken cancellationToken)
    {
        var accountId = Guid.Parse(request.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value);
        var accountOutfitLikeDTO = new AccountOutfitLikeCreateDTO(request.OutfitId, accountId);
        var validationResult = await _validator.ValidateAsync(accountOutfitLikeDTO);
        if (!validationResult.IsValid) throw new ValidationFailedException("Validation failed", validationResult.Errors.Select(error => error.ErrorMessage));
        var accountOutfitLike = _mapper.Map<AccountOutfitLike>(accountOutfitLikeDTO);
        var searchedAccountOutfitLike = await _likeRepository.GetAsyncByAccountAndOutfitId(accountOutfitLike);
        if (searchedAccountOutfitLike != null) await _likeRepository.DeleteAsync(searchedAccountOutfitLike);
        else await _likeRepository.AddAsync(accountOutfitLike);
        var likes = await _likeRepository.GetOutfitLikesAsync(request.OutfitId);
        var mappedLikes = _mapper.Map<List<AccountOutfitLikeReadDTO>>(likes);
        foreach (var like in mappedLikes)
        {
            var account = await _accountRepository.GetByIdAsync(like.AccountId);
            var mappedAccounts = _mapper.Map<AccountGeneralInfoReadDTO>(account);
            like.Account = mappedAccounts;
        }
        return mappedLikes;
    }
}
