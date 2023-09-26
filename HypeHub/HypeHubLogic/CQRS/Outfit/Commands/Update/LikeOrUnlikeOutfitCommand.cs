using HypeHubLogic.DTOs.AccountOutfitLike;
using MediatR;

namespace HypeHubLogic.CQRS.Outfit.Commands.Update;

public class LikeOrUnlikeOutfitCommand : IRequest
{
    public AccountOutfitLikeCreateDTO AccountOutfitLike { get; init; }

    public LikeOrUnlikeOutfitCommand(AccountOutfitLikeCreateDTO accountOutfitLike)
    {
        AccountOutfitLike = accountOutfitLike;
    }
}
