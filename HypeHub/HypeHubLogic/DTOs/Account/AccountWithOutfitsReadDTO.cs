using HypeHubDAL.Models.Types;
using HypeHubLogic.DTOs.Outfit;

namespace HypeHubLogic.DTOs.Account;

public class AccountWithOutfitsReadDTO
{
    public Guid Id { get; init; }
    public string Username { get; set; }
    public List<OutfitGeneralReadDTO> Outfits { get; set; }
    public string? AvatarUrl { get; set; }
}
