using HypeHubDAL.Exeptions;
using HypeHubDAL.Repositories.Interfaces;
using MediatR;

namespace HypeHubLogic.CQRS.Outfit.Commands.Delete;

public class DeleteOutfitImageCommandHandler : IRequestHandler<DeleteOutfitImageCommand>
{
    private readonly IOutfitRepository _outfitRepository;

    public DeleteOutfitImageCommandHandler(IOutfitRepository outfitRepository)
    {
        _outfitRepository = outfitRepository;
    }

    public async Task Handle(DeleteOutfitImageCommand request, CancellationToken cancellationToken)
    {
        var outfitImage = await _outfitRepository.GetOutfitImageByIdAsync(request.OutfitId, request.OutfitImageId) ?? throw new NotFoundException("There is no Image with the given Id.");

        await _outfitRepository.DeleteOutfitImageAsync(request.OutfitId, outfitImage);
    }
}