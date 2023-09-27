using AutoMapper;
using HypeHubDAL.Repositories;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.DTOs.ItemImage;
using HypeHubLogic.DTOs.OutfitImage;
using MediatR;

namespace HypeHubLogic.CQRS.Item.Queries;

public class GetItemImageQueryHandler : IRequestHandler<GetItemImageQuery,ItemImageReadDTO>
{
    private readonly IItemImageRepository _itemImageRepository;
    private readonly IMapper _mapper;

    public GetItemImageQueryHandler(IItemImageRepository itemImageRepository, IMapper mapper)
    {
        _itemImageRepository = itemImageRepository;
        _mapper = mapper;
    }

    public async Task<ItemImageReadDTO> Handle(GetItemImageQuery request, CancellationToken cancellationToken)
    {
        var itemImage = await _itemImageRepository.GetByIdAsync(request.ItemImageId);
        return _mapper.Map<ItemImageReadDTO>(itemImage);
    }
}
