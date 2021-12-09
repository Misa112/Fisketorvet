using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Fisketorvet.Pages.Users
{
    public class LoginModel : PageModel
    {
        public string Username { get; set; }

        public string Password { get; set; }
        public void OnGet()
        {
        }
    }
}
