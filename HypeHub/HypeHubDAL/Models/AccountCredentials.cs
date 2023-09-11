namespace HypeHubDAL.Models;

public class AccountCredentials
{
    public Guid Id { get; init; }
    public Account Account { get; init; }
    public Guid AccountId { get; init; }
    public string Password { get; set; }
    public string Email { get; set; }

    public AccountCredentials(Guid accountId, string password, string email)
    {
        Id = Guid.NewGuid();
        AccountId = accountId;
        Password = password;
        Email = email;
    }
}
