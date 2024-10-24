using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LucidMarket.Services;
using LucidMarket.Abstractions;

namespace LucidMarket.Model
{
    public class Cart : ClassExtent<Cart>
    {
        public string CartID { get; set; }
        public Customer Customer { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();

        public Cart(string cartId, Customer customer)
        {
            CartID = cartId;
            Customer = customer;
        }
    }
}

