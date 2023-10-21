namespace HypeHubLogic.DTOs.Account;
public class AccountDeleteDTO
{
    public Guid Id { get; set; }
    public string Email { get; set; }
    public AccountDeleteDTO(Guid id, string email)
    {
        Id = id;
        Email = email;
    }
}
