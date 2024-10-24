using LucidMarket.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucidMarket.Model.Products
{
    public class Accessory : ClassExtent<Accessory>
    {
        public string CompatibilityInformation { get; set; }
    }
}
