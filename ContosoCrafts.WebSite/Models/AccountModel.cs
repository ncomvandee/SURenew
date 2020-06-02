using Microsoft.CodeAnalysis.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SURenew.Models
{
    // The Account Model class recieves and validates user email and password input. 
    public class AccountModel
    {
        //Get/Set method for accessing user E-mail
        public string Email { get; set; }
        
        //Get/Set method for accessing user Password.
        public string password { get; set; }

    }
}
