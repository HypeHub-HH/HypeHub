using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HypeHubDAL.Models
{
    public class AccountCredentials
    {
        public Guid Id { get; set; }
        public Guid AccountId { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Account Account { get; set; }

        public AccountCredentials(Guid id, Guid accountId, string password, string email)
        {
            Id = Guid.NewGuid();
            AccountId = accountId;
            Password = password;
            Email = email;
        }
    }
}
