using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Fisketorvet.Interfaces;
using Fisketorvet.Models;
using Fisketorvet.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Fisketorvet.Pages.Users
{
    public class LoginModel : PageModel
    {
        ICustomerRepository userService;

        [BindProperty]
        public CustomerViewModel CustomerViewModel { get; set; }

        public LoginModel(ICustomerRepository service) {
            userService = service;
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost() {
            return CheckLogin();
        }
        private IActionResult CheckLogin()
        {
            Customer validUser = userService.GetValidUser(CustomerViewModel.Email, CustomerViewModel.Password);
            if (!String.IsNullOrEmpty(validUser.Email))
            {

                if (validUser.IsAdmin == true)
                {
                    // an admin
                    HttpContext.Session.SetString("admin", validUser.Email);
                    return Redirect("../Customers/AllCustomers");
                }
                //normal user with a login account
                else
                {
                    HttpContext.Session.SetString("normal", validUser.Email);
                    return Redirect("/Index");
                }
            }
            // no login account
            else
            {
                return RedirectToPage("Login");
            }
        }
    }
}
