using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fisketorvet.Models
{
    public class Customer
    {
       
        public int CustomerId { get; set; }

        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        public int PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public bool IsAdmin { set; get; }
    }
}