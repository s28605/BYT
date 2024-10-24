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
            var customer = new Customer("ACC123", "Bruce Wayne", "brc@wayne.com", "525-1938", "Bovery 52", 52);
            Customer.Persist();

            var specifications = new Specifications("Intel i7", 16);
            var product = new Product("P001", "Laptop", "Asus", 1200.00, "Black", "2 years", specifications);
            Product.Persist();
        }
    }
}
