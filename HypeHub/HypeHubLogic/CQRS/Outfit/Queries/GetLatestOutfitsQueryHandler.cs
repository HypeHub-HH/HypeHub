using AutoMapper;
using HypeHubDAL.Exeptions;
using HypeHubDAL.Models;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.Account;
using HypeHubLogic.DTOs.Outfit;
using MediatR;

namespace HypeHubLogic.CQRS.Outfit.Queries;
public class GetLatestOutfitsQueryHandler : IRequestHandler<GetLatestOutfitsQuery, PagedList<OutfitWithAccountAndImagesAndLikesReadDTO>>
{
    private readonly IOutfitRepository _outfitRepository;
    private readonly IAccountRepository _accountRepository;
    private readonly IMapper _mapper;
    public GetLatestOutfitsQueryHandler(IOutfitRepository outfitRepository, IAccountRepository accountRepository, IMapper mapper)
    {
        _outfitRepository = outfitRepository;
        _accountRepository = accountRepository;
        _mapper = mapper;
    }
    public async Task<PagedList<OutfitWithAccountAndImagesAndLikesReadDTO>> Handle(GetLatestOutfitsQuery request, CancellationToken cancellationToken)
    {
        if (request.Page <= 0 || request.PageSize <= 0) throw new BadRequestException("Page and PageSize parameters must be greater than zero.");
        var pagedOutfits = await _outfitRepository.GetLatesOutfitsWithAccountsAndImagesAndLikesAsync(request.Page, request.PageSize);
        var pagedList = new PagedList<OutfitWithAccountAndImagesAndLikesReadDTO>(
            pagedOutfits.Entities.Select(outfit => _mapper.Map<OutfitWithAccountAndImagesAndLikesReadDTO>(outfit)).ToList(),
            pagedOutfits.TotalCount,
            pagedOutfits.CurrentPage,
            pagedOutfits.PageSize);

        foreach (var outfit in pagedList.Entities)
        {
            foreach (var like in outfit.Likes)
            {
                var account = await _accountRepository.GetByIdAsync(like.AccountId);
                var mappedAccounts = _mapper.Map<AccountGeneralInfoReadDTO>(account);
                like.Account = mappedAccounts;
            }
        }
        return pagedList;
    }
}
