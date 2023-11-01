using AutoMapper;
using HypeHubDAL.Exeptions;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.Account;
using HypeHubLogic.DTOs.Outfit;
using MediatR;

namespace HypeHubLogic.CQRS.Outfit.Queries;
public class GetOutfitWithAccountAndLikesAndImagesAndItemsQueryHandler : IRequestHandler<GetOutfitWithAccountAndLikesAndImagesAndItemsQuery, OutfitWithAccountAndImagesAndLikesAndItemsReadDTO>
{
    private readonly IOutfitRepository _outfitRepository;
    private readonly IAccountRepository _accountRepository;
    private readonly IMapper _mapper;
    public GetOutfitWithAccountAndLikesAndImagesAndItemsQueryHandler(IOutfitRepository outfitRepository, IAccountRepository accountRepository, IMapper mapper)
    {
        _outfitRepository = outfitRepository;
        _accountRepository = accountRepository;
        _mapper = mapper;
    }
    public async Task<OutfitWithAccountAndImagesAndLikesAndItemsReadDTO> Handle(GetOutfitWithAccountAndLikesAndImagesAndItemsQuery request, CancellationToken cancellationToken)
    {
        var outfit = await _outfitRepository.GetOutfitWithAccountAndItemsAndLikesAsync(request.OutfitId) ?? throw new NotFoundException($"There is no outfit with the given Id: {request.OutfitId}.");
        var mappedOutfit = _mapper.Map<OutfitWithAccountAndImagesAndLikesAndItemsReadDTO>(outfit);

        foreach (var like in mappedOutfit.Likes)
        {
            var account = await _accountRepository.GetByIdAsync(like.AccountId);
            var mappedAccounts = _mapper.Map<AccountGeneralInfoReadDTO>(account);
            like.Account = mappedAccounts;
        }
        return mappedOutfit;
    }
}