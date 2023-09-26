using AutoMapper;
using FluentValidation;
using HypeHubDAL.Exeptions;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.ItemImage;
using MediatR;

namespace HypeHubLogic.CQRS.Item.Commands.Post;

public class AddPhotoToItemCommandHandler : IRequestHandler<AddPhotoToItemCommand>
{
    private readonly IItemImageRepository _imageItemRepository;
    private readonly IMapper _mapper;
    private readonly IValidator<ItemImageCreateDTO> _validator;

    public AddPhotoToItemCommandHandler(IItemImageRepository imageItemRepository, IMapper mapper, IValidator<ItemImageCreateDTO> validator)
    {
        _imageItemRepository = imageItemRepository;
        _mapper = mapper;
        _validator = validator;
    }

    public async Task Handle(AddPhotoToItemCommand request, CancellationToken cancellationToken)
    {
        var validationResult = await _validator.ValidateAsync(request.ItemImage);
        if (!validationResult.IsValid)
        {
            throw new ValidationFailedException("Validation failed", validationResult);
        }
    }
}
