using HypeHubDAL.Exeptions;
using HypeHubDAL.Repositories.Interfaces;
using MediatR;

namespace HypeHubLogic.CQRS.Outfit.Commands.Delete;

public class DeleteOutfitCommandHandler : IRequestHandler<DeleteOutfitCommand>
{
    private readonly IOutfitRepository _outfitRepository;

    public DeleteOutfitCommandHandler(IOutfitRepository outfitRepository)
    {
        _outfitRepository = outfitRepository;
    }

    public async Task Handle(DeleteOutfitCommand request, CancellationToken cancellationToken)
    {
        var outfit = await _outfitRepository.GetByIdAsync(request.OutfitId) ?? throw new NotFoundException($"There is no outfit with the given Id: {request.OutfitId}.");
        await _outfitRepository.DeleteAsync(outfit);
    }
}