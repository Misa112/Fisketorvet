using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fisketorvet.Models
{
    public class Customer
    {
        [Required]
        public int CustomerId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Address { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [EmailAddress, Required]
        public string Email { get; set; }
    }
}