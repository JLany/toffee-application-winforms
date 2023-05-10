using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToffeeSystemPrototype.AccountComponent
{
    public class AccountComponent 
        : OrderAccountServicesContract
        , AccountManagementContract
        , AuthenticationAccountServicesContract
    {
        /// <summary>
        /// Represents Email, <see cref="Account"/> pairs
        /// </summary>
        private Dictionary<string, Account> accounts = new Dictionary<string, Account>();
        // private EmailClient client;

        public AccountComponent() { }


        // services for order component
        public string GetAddressOf(string accountEmail)
        {
            return accounts[accountEmail].Address;
        }

        public bool ValidateVouchers(int accoutnId, List<int> voucherIds)
        {
            return true;
        }

        public decimal RedeemVouchers(int accountId, List<int> voucherIds)
        {
            return 15m;
        }

        public decimal RedeemLP(int accountId, int lpAmount)
        {
            return 5m;
        }

        public void CreditLP(int accountId, int lpAmount)
        {

        }

        public void SendMailTo(int accountId, string mailMessage)
        {

        }

        // services for accounts controller

        public bool SignUpCustomer(string username, string password
            , string email, string address)
        {
            if (accounts.ContainsKey(email))
            {
                return false;
            }
            accounts.Add(email,
                new Account(username, password, email, address, AccountType.Cutsomer));

            return true;
        }

        public bool AuthenticateAccount(string email, string password)
        {
            if (accounts.ContainsKey(email))
            {
                if (accounts[email].Password == password)
                    return true;
            }

            return false;
        }
    }
}
