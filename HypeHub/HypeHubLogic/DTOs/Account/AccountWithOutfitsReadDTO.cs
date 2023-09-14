using HypeHubLogic.DTOs.Outfit;

namespace HypeHubLogic.DTOs.Account;

public class AccountWithOutfitsReadDTO
{
    public Guid Id { get; init; }
    public string Username { get; init; }
    public List<OutfitReadDTO> Outfits { get; init; }
    public string? AvatarUrl { get; init; }
}
