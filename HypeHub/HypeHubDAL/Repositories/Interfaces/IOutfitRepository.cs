using HypeHubDAL.Models;

namespace HypeHubDAL.Repositories.Interfaces;

public interface IOutfitRepository
{
    Task DeleteAsync(Outfit outfit);
}
