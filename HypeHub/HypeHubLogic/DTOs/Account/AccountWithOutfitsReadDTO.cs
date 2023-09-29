using HypeHubLogic.DTOs.Outfit;

namespace HypeHubLogic.DTOs.Account;

public record AccountWithOutfitsReadDTO
{
    public Guid Id { get; init; }
    public string Username { get; set; }
    public List<OutfitWithImagesAndLikesCountReadDTO> Outfits { get; set; }
    public string? AvatarUrl { get; set; }
}
