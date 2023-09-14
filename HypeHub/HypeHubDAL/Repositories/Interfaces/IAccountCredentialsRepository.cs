namespace HypeHubDAL.Repositories.Interfaces;

public interface IAccountCredentialsRepository
{
    Task<bool> CheckIfEmailAlreadyExistAsync(string email);
}
