using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SodaPop.DL
{
    public class UserAccount

        {   //list for account data to be used
            public int userId { get; set; }
            public string email { get; set; }
            public string userPassword { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public int phoneNumber { get; set; }
            public string userAddress { get; set; }
        }
    
}