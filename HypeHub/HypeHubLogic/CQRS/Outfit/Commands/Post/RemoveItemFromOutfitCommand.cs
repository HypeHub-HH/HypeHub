using HypeHubDAL.Models.Relations;
using MediatR;
using System.Security.Claims;

namespace HypeHubLogic.CQRS.Outfit.Commands.Post;

public class RemoveItemFromOutfitCommand : IRequest
{
    public OutfitItem OutfitItem { get; init; }
    public IEnumerable<Claim> Claims { get; init; }
    public RemoveItemFromOutfitCommand(OutfitItem outfitItem, IEnumerable<Claim> claims)
    {
        OutfitItem = outfitItem;
        Claims = claims;
    }
}