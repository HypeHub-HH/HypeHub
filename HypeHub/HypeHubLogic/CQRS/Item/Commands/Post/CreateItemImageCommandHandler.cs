using AutoMapper;
using FluentValidation;
using HypeHubDAL.Exeptions;
using HypeHubDAL.Models;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.ItemImage;
using HypeHubLogic.Validators;
using MediatR;

namespace HypeHubLogic.CQRS.Item.Commands.Post;
public class CreateItemImageCommandHandler : IRequestHandler<CreateItemImageCommand, ItemImageReadDTO>
{
    private readonly IItemImageRepository _imageItemRepository;
    private readonly IMapper _mapper;
    private readonly IValidator<ItemImageCreateDTO> _validator;
    private readonly IOwnershipValidator _ownershipValidator;
    public CreateItemImageCommandHandler(IItemImageRepository imageItemRepository, IMapper mapper, IValidator<ItemImageCreateDTO> validator, IOwnershipValidator ownershipValidator)
    {
        _imageItemRepository = imageItemRepository;
        _mapper = mapper;
        _validator = validator;
        _ownershipValidator = ownershipValidator;
    }
    public async Task<ItemImageReadDTO> Handle(CreateItemImageCommand request, CancellationToken cancellationToken)
    {
        if (!await _ownershipValidator.ValidateOwnership(request.Claims, request.ItemImage.ItemId)) throw new UnauthorizedRequestExeption("Access denied. Only owner can acces this endpoint");
        var validationResult = await _validator.ValidateAsync(request.ItemImage);
        if (!validationResult.IsValid) throw new ValidationFailedException("Validation failed", validationResult.Errors.Select(error => error.ErrorMessage));
        var itemImage = _mapper.Map<ItemImage>(request.ItemImage);
        var createdItemImage = await _imageItemRepository.AddAsync(itemImage);
        return _mapper.Map<ItemImageReadDTO>(createdItemImage);
    }
}
