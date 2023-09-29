using HypeHubLogic.DTOs.Account;
using HypeHubLogic.DTOs.AccountOutfitLike;
using HypeHubLogic.DTOs.Item;
using HypeHubLogic.DTOs.OutfitImage;

namespace HypeHubLogic.DTOs.Outfit;

public record OutfitWithAccountAndImagesAndLikesAndItemsReadDTO
{
    public Guid Id { get; init; }
    public AccountGeneralInfoReadDTO Account { get; init; }
    public string Name { get; init; }
    public DateTime CreationDate { get; init; }
    public List<ItemWithImagesAndLikesReadDTO> Items { get; init; }
    public List<AccountOutfitLikeReadDTO> Likes { get; init; }
    public List<OutfitImageReadDTO> Images { get; init; }
}