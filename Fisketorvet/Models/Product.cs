using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fisketorvet.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Name of the product can not be longer than 20 characters.")]
        public string ProductName { get; set; }
        [Required]
        public int Price { get; set; }
        public string ImageName { get; set; }
    }
}
