using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToffeeSystemPrototype.AccountComponent
{
    public interface AccountManagementContract
    {
        // this should be an internal method, because the controller does know about
        // `change password` logic, thus does not know that a mail should be sent
        // but this is just for illustration and testing purposes
        public void SendMailTo(int accountId, string mailMessage);
    }
}
