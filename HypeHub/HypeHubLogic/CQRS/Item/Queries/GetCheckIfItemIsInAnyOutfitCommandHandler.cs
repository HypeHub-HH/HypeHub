using HypeHubDAL.Repositories.Interfaces;
using MediatR;

namespace HypeHubLogic.CQRS.Item.Queries;
public class GetCheckIfItemIsInAnyOutfitCommandHandler : IRequestHandler<GetCheckIfItemIsInAnyOutfitCommand, bool>
{
    private readonly IOutfitItemRepository _outfitItemRepository;

    public GetCheckIfItemIsInAnyOutfitCommandHandler(IOutfitItemRepository outfitItemRepository)
    {
        _outfitItemRepository = outfitItemRepository;
    }

    public async Task<bool> Handle(GetCheckIfItemIsInAnyOutfitCommand request, CancellationToken cancellationToken)
    {
        return await _outfitItemRepository.CheckIfItemIsInAnyOutfitAsync(request.ItemId);
    }
}
