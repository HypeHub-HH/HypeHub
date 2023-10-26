using HypeHubLogic.DTOs.Account;
using HypeHubLogic.DTOs.AccountOutfitLike;
using HypeHubLogic.DTOs.OutfitImage;

namespace HypeHubLogic.DTOs.Outfit;
public record OutfitWithAccountAndImagesAndLikesReadDTO
{
    public Guid Id { get; init; }
    public AccountGeneralInfoReadDTO Account { get; init; }
    public string Name { get; init; }
    public DateTime CreationDate { get; init; }
    public List<OutfitImageReadDTO> Images { get; init; }
    public List<AccountOutfitLikeReadDTO> Likes { get; init; }
}