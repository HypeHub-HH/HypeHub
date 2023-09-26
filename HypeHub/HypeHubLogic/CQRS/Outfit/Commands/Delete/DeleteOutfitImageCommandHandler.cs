using HypeHubDAL.Exeptions;
using HypeHubDAL.Repositories.Interfaces;
using MediatR;

namespace HypeHubLogic.CQRS.Outfit.Commands.Delete;

public class DeleteOutfitImageCommandHandler : IRequestHandler<DeleteOutfitImageCommand>
{
    private readonly IOutfitImageRepository _outfitImageRepository;

    public DeleteOutfitImageCommandHandler(IOutfitImageRepository outfitImageRepository)
    {
        _outfitImageRepository = outfitImageRepository;
    }

    public async Task Handle(DeleteOutfitImageCommand request, CancellationToken cancellationToken)
    {
        var outfitImage = await _outfitImageRepository.GetByIdAsync(request.OutfitImageId) ?? throw new NotFoundException("There is no Image with the given Id.");

        await _outfitImageRepository.DeleteAsync(outfitImage);
    }
}