using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LucidMarket.Services;
using LucidMarket.Abstractions;

namespace LucidMarket.Model
{
    public class Product : ClassExtent<Product>
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }
        public string Color { get; set; }
        public string WarrantyPeriod { get; set; }
        public Specifications Specifications { get; set; }

        public Product(string id, string name, string brand, double price, string color, string warrantyPeriod, Specifications specifications)
        {
            Id = id;
            Name = name;
            Brand = brand;
            Price = price;
            Color = color;
            WarrantyPeriod = warrantyPeriod;
            Specifications = specifications;
        }
    }

    public class Specifications
    {
        public string ProcessorType { get; set; }
        public int MemorySize { get; set; }

        public Specifications(string processorType, int memorySize)
        {
            ProcessorType = processorType;
            MemorySize = memorySize;
        }
    }
}
