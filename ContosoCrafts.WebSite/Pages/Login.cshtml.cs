using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SURenew.Models;

namespace SURenew.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public AccountModel Account { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            
            if (Account.Email == "jbarron@seattleu.edu") 
            {
                return RedirectToPage("/AdminPortal");
                
            }
            
            if (Account.Email == "eedwards@seattleu.edu")
            {
                return RedirectToPage("/Homepage");
            } 
            else
            {
                return RedirectToPage("/Login");
            }

            
        }
    }
}