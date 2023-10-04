using AutoMapper;
using Azure.Core;
using FluentValidation;
using HypeHubDAL.Exeptions;
using HypeHubDAL.Models.Relations;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.AccountItemLike;
using MediatR;
using System.Security.Claims;

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
        var accountId = Guid.Parse(request.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value);
        var accountItemLikeDTO = new AccountItemLikeCreateDTO(request.ItemId, accountId);
        var validationResult = await _validator.ValidateAsync(accountItemLikeDTO);
        if (!validationResult.IsValid) throw new ValidationFailedException("Validation failed", validationResult.Errors.Select(error => error.ErrorMessage));
        var accountItemLike = _mapper.Map<AccountItemLike>(accountItemLikeDTO);
        var searchedAccountItemLike = await _likeRepository.GetAsyncByAccountAndItemId(accountItemLike);
        if (searchedAccountItemLike != null) await _likeRepository.DeleteAsync(searchedAccountItemLike);
        else await _likeRepository.AddAsync(accountItemLike);
    }
}
