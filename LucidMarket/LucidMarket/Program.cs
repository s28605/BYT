using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LucidMarket.Model;

namespace LucidMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer { Name = "John Doe", Email = "john@example.com" };
            Customer.Persist();

            var product = new Product { Name = "Laptop", Price = 1200.00 };
            Product.Persist();
        }
    }
}
