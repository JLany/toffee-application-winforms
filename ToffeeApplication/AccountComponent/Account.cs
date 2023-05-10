using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToffeeSystemPrototype.AccountComponent
{
    public class Account
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public AccountType AccountType { get; set; }
        public AccountStatus AccountStatus { get; set; } = AccountStatus.Active;

        public Account(string username, string password, string email, string address
            , AccountType accountType) 
        {
            Username = username;
            Password = password;
            Email = email;
            Address = address;
            AccountType = accountType;
        }
    }
}
