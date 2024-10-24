using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LucidMarket.Services;
using LucidMarket.Abstractions;

namespace LucidMarket.Model
{
    public class Supplier : ClassExtent<Supplier>
    {
        public string SupplierID { get; set; }
        public string Name { get; set; }
        public string ContactInformation { get; set; }

        public Supplier(string supplierId, string name, string contactInformation)
        {
            SupplierID = supplierId;
            Name = name;
            ContactInformation = contactInformation;
        }
    }
}

