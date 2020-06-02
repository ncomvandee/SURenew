using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SURenew.Models;

namespace SURenew.Pages
{
    public class DefaultLoginModel : PageModel
    {

        // AccountModel property using for retrieve email and password input
        [BindProperty]
        public AccountModel Account { get; set; }

        public void OnGet()
        {

        }

        // The logic function to distinguish between user and administrator
        public IActionResult OnPost()
        {
            // If login with this email(admin), site will navigate to AdminPortal
            if (Account.Email == "jbarron@seattleu.edu") 
            {
                return RedirectToPage("/AdminPortal"); 
            }
            // If login with this email(user), site will navigate to Homepage
            if (Account.Email == "eedwards@seattleu.edu")
            {
                return RedirectToPage("/Homepage");
            }
            // Other than above valid email, the site will not allow to access
            else
            {
                return RedirectToPage("/Login");
            }

            
        }
    }
}