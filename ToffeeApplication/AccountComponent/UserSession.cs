using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToffeeSystemPrototype.AccountComponent
{
    public class UserSession
    {
        public string UserEmail { get; set; }
        public DateTime Started { get; set; }

        public UserSession(string userEmail, DateTime started) 
        { 
            UserEmail = userEmail;
            Started = started;
        }
    }
}
