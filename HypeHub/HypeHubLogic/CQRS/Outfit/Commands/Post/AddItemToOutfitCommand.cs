using HypeHubDAL.Models.Relations;
using MediatR;
using System.Security.Claims;

namespace HypeHubLogic.CQRS.Outfit.Commands.Post;
public class AddItemToOutfitCommand : IRequest<OutfitItem>
{
    public OutfitItem OutfitItem { get; init; }
    public IEnumerable<Claim> Claims { get; init; }
    public AddItemToOutfitCommand(OutfitItem outfitItem, IEnumerable<Claim> claims)
    {
        OutfitItem = outfitItem;
        Claims = claims;
    }
}