using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LucidMarket.Services;
using LucidMarket.Abstractions;

namespace LucidMarket.Model
{
    public class Inventory : ClassExtent<Inventory>
    {
        public double CurrentStockLevel { get; set; }
        public double RestockThreshold { get; set; }
        public double RestockFrequency { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();

        public Inventory(double currentStockLevel, double restockThreshold, double restockFrequency)
        {
            CurrentStockLevel = currentStockLevel;
            RestockThreshold = restockThreshold;
            RestockFrequency = restockFrequency;
        }
    }
}
