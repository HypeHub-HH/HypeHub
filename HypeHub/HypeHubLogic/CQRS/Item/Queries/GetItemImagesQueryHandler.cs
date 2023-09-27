using AutoMapper;
using HypeHubDAL.Exeptions;
using HypeHubDAL.Repositories.Interfaces;
using HypeHubLogic.CQRS.Outfit.Queries;
using HypeHubLogic.DTOs.ItemImage;
using HypeHubLogic.DTOs.OutfitImage;
using MediatR;

namespace HypeHubLogic.CQRS.Item.Queries;

public class GetItemImagesQueryHandler : IRequestHandler<GetItemImagesQuery, List<ItemImageReadDTO>>
{
    private readonly IItemImageRepository _itemImageRepository;
    private readonly IItemRepository _itemRepository;
    private readonly IMapper _mapper;

    public GetItemImagesQueryHandler(IItemImageRepository itemImageRepository, IMapper mapper, IItemRepository itemRepository)
    {
        _itemImageRepository = itemImageRepository;
        _mapper = mapper;
        _itemRepository = itemRepository;
    }

    public async Task<List<ItemImageReadDTO>> Handle(GetItemImagesQuery request, CancellationToken cancellationToken)
    {
        if (_itemRepository.GetByIdAsync(request.ItemId) == null) throw new NotFoundException($"There is no item with given id:{request.ItemId}");
        var itemImages = await _itemImageRepository.GetAllItemImagesAsync(request.ItemId);
        return _mapper.Map<List<ItemImageReadDTO>>(itemImages);
    }
}
