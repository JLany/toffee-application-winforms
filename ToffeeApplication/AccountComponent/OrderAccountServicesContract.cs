using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToffeeSystemPrototype.AccountComponent
{
    public interface OrderAccountServicesContract
    {
        public string GetAddressOf(string accountEmail);
        public bool ValidateVouchers(int accountId, List<int> voucherIds);
        public decimal RedeemVouchers(int accountId, List<int> voucherIds);
        public decimal RedeemLP(int accountId, int lpAmount);
        public void CreditLP(int accountId, int lpAmount);
        public void SendMailTo(int accountId, string mailMessage);
    }
}
