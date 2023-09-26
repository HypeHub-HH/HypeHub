using AutoMapper;
using FluentValidation;
using HypeHubDAL.Exeptions;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.AccountOutfitLike;
using MediatR;

namespace HypeHubLogic.CQRS.Outfit.Commands.Update;

public class LikeOrUnlikeOutfitCommandHandler : IRequestHandler<LikeOrUnlikeOutfitCommand>
{
    private readonly IAccountOutfitLikeRepository _likeRepository;
    private readonly IMapper _mapper;
    private readonly IValidator<AccountOutfitLikeCreateDTO> _validator;

    public LikeOrUnlikeOutfitCommandHandler(IAccountOutfitLikeRepository likeRepository, IMapper mapper, IValidator<AccountOutfitLikeCreateDTO> validator)
    {
        _likeRepository = likeRepository;
        _mapper = mapper;
        _validator = validator;
    }

    public async Task Handle(LikeOrUnlikeOutfitCommand request, CancellationToken cancellationToken)
    {
        var validationResult = await _validator.ValidateAsync(request.AccountOutfitLike);
        if (!validationResult.IsValid) throw new ValidationFailedException("Validation failed", validationResult);
        var accountOutfitLike = _mapper.Map<HypeHubDAL.Models.Relations.AccountOutfitLike>(request.AccountOutfitLike);
        var searchedAccountOutfitLike = await _likeRepository.GetAsyncByAccountAndOutfitId(accountOutfitLike);

        if (searchedAccountOutfitLike != null) await _likeRepository.DeleteAsync(searchedAccountOutfitLike);
        else await _likeRepository.AddAsync(accountOutfitLike);
    }
}
