using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fisketorvet.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public string Name { get; set; }
        public string ShippingAddress { get; set; }
        public List<Product> Products { get; set; }
        public DateTime DateTime { get; set; }
    }
}
