using LucidMarket.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucidMarket.Model.Products
{
    public class Tablet : ClassExtent<Tablet>
    {
        public string ProcessorType { get; set; }
        public int MemorySize { get; set; }
    }
}
