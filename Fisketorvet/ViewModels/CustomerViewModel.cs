using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fisketorvet.ViewModels
{
    public class CustomerViewModel
    {
        public int CustomerId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Address { get; set; }

        [DataType(DataType.PhoneNumber)]
        public int PhoneNumber { get; set; }

        [EmailAddress, Required]
        public string Email { get; set; }

        [Required(ErrorMessage = "The password is required "), MaxLength(30)]
        public string Password { get; set; }

        [Required(ErrorMessage = "This field is required "), MaxLength(30)]
        public string ConfirmPassword { get; set; }

        public bool IsAdmin { set; get; }
    }
}
