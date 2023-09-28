using AutoMapper;
using HypeHubDAL.Models;
using HypeHubDAL.Models.Relations;
using HypeHubLogic.DTOs.Account;
using HypeHubLogic.DTOs.AccountCredentials;
using HypeHubLogic.DTOs.AccountItemLike;
using HypeHubLogic.DTOs.AccountOutfitLike;
using HypeHubLogic.DTOs.Item;
using HypeHubLogic.DTOs.ItemImage;
using HypeHubLogic.DTOs.Outfit;
using HypeHubLogic.DTOs.OutfitImage;

namespace HypeHubLogic.Mappers;

public class MapProfile : Profile
{
    public MapProfile()
    {
        CreateMap<Account, AccountGeneralInfoReadDTO>();
        CreateMap<Account, AccountWithCredentialsReadDTO>();
        CreateMap<Account, AccountWithOutfitsReadDTO>();
        CreateMap<Account, AccountWithItemsReadDTO>();
        CreateMap<AccountCreateDTO, Account>();
        CreateMap<Account, AccountWithOutfitsReadDTO>();

        CreateMap<AccountCredentials, AccountCredentialsReadDTO>();
        CreateMap<AccountCredentialsCreateDTO, AccountCredentials>();

        CreateMap<AccountItemLike, AccountItemLikeReadDTO>();
        CreateMap<AccountItemLikeCreateDTO, AccountItemLike>();

        CreateMap<AccountOutfitLike, AccountOutfitLikeReadDTO>();
        CreateMap<AccountOutfitLikeCreateDTO, AccountOutfitLike>();

        CreateMap<Item, ItemReadDTO>();
        CreateMap<ItemCreateDTO, Item>();

        CreateMap<ItemImage, ItemImageReadDTO>();
        CreateMap<ItemImageCreateDTO, ItemImage>();

        CreateMap<Outfit, OutfitReadDTO>();
        CreateMap<Outfit, OutfitGeneralReadDTO>()
            .ForMember(dest => dest.Likes, opt => opt.MapFrom(src => src.Likes.Count()));
        CreateMap<OutfitCreateDTO, Outfit>();

        CreateMap<OutfitImage, OutfitImageReadDTO>();
        CreateMap<OutfitImageCreateDTO, OutfitImage>();
    }
}
