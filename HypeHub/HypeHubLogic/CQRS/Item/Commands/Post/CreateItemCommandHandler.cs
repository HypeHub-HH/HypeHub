using AutoMapper;
using FluentValidation;
using HypeHubDAL.Exeptions;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.Item;
using MediatR;
using System.Security.Claims;

namespace HypeHubLogic.CQRS.Item.Commands.Post;
public class CreateItemCommandHandler : IRequestHandler<CreateItemCommand, ItemGenerallReadDTO>
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
    public async Task<ItemGenerallReadDTO> Handle(CreateItemCommand request, CancellationToken cancellationToken)
    {
        var userId = Guid.Parse(request.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value);
        var validationResult = await _validator.ValidateAsync(request.Item);
        if (!validationResult.IsValid) throw new ValidationFailedException("Validation failed", validationResult.Errors.Select(error => error.ErrorMessage));
        var item = new HypeHubDAL.Models.Item(userId, request.Item.Name, request.Item.CloathingType, request.Item.Brand, request.Item.Model, request.Item.Colorway, request.Item.Price, request.Item.PurchaseDate);
        var createdItem = await _itemRepository.AddAsync(item) ?? throw new InternalEntityServerException("Server failed", new List<string>() { "Item has not been created." });
        var addedItem = _mapper.Map<ItemGenerallReadDTO>(createdItem);
        return addedItem;
    }
}
