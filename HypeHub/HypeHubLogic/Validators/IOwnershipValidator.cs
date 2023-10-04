using System.Security.Claims;

namespace HypeHubLogic.Validators
{
    public interface IOwnershipValidator
    {
        Task<bool> ValidateOwnership(IEnumerable<Claim> claims, Guid subjectId);
    }
}