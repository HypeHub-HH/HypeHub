using AutoMapper;
using FluentValidation;
using HypeHubDAL.Exeptions;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.AccountItemLike;
using MediatR;

namespace HypeHubLogic.CQRS.Item.Commands.Update;

public class LikeOrUnlikeItemCommandHandler : IRequestHandler<LikeOrUnlikeItemCommand>
{
    private readonly IAccountItemLikeRepository _likeRepository;
    private readonly IMapper _mapper;
    private readonly IValidator<AccountItemLikeCreateDTO> _validator;

    public LikeOrUnlikeItemCommandHandler(IAccountItemLikeRepository likeRepository, IMapper mapper, IValidator<AccountItemLikeCreateDTO> validator)
    {
        _likeRepository = likeRepository;
        _mapper = mapper;
        _validator = validator;
    }

    public async Task Handle(LikeOrUnlikeItemCommand request, CancellationToken cancellationToken)
    {
        var validationResult = await _validator.ValidateAsync(request.AccountItemLike);
        if (!validationResult.IsValid) throw new ValidationFailedException("Validation failed", validationResult);
        var accountItemLike = _mapper.Map<HypeHubDAL.Models.Relations.AccountItemLike>(request.AccountItemLike);
        var searchedAccountItemLike = await _likeRepository.GetAsyncByAccountAndItemId(accountItemLike);

        if (searchedAccountItemLike != null) await _likeRepository.DeleteAsync(searchedAccountItemLike);
        else await _likeRepository.AddAsync(accountItemLike);
    }
}
