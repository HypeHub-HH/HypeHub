using AutoMapper;
using FluentValidation;
using HypeHubDAL.Exeptions;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.Item;
using MediatR;

namespace HypeHubLogic.CQRS.Item.Commands.Post;

public class CreateItemCommandHandler : IRequestHandler<CreateItemCommand, ItemReadDTO>
{
    private readonly IItemRepository _itemRepository;
    private readonly IMapper _mapper;
    private readonly IValidator<ItemCreateDTO> _validator;

    public CreateItemCommandHandler(IItemRepository itemRepository, IMapper mapper, IValidator<ItemCreateDTO> validator)
    {
        _itemRepository = itemRepository;
        _mapper = mapper;
        _validator = validator;
    }

    public async Task<ItemReadDTO> Handle(CreateItemCommand request, CancellationToken cancellationToken)
    {
        var validationResult = await _validator.ValidateAsync(request.Item);
        if (!validationResult.IsValid) throw new ValidationFailedException("Validation failed", validationResult.Errors.Select(error => error.ErrorMessage));
        var item = _mapper.Map<HypeHubDAL.Models.Item>(request.Item);
        var createdItem = await _itemRepository.AddAsync(item);
        var addedItem = _mapper.Map<ItemReadDTO>(createdItem);
        return addedItem;
    }
}
