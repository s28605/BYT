using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LucidMarket.Services;
using LucidMarket.Abstractions;

namespace LucidMarket.Model
{
    public class PaymentMethod : ClassExtent<PaymentMethod>
    {
        public string PaymentID { get; set; }
        public double PaymentAmount { get; set; }
        public string PaymentType { get; set; }

        public PaymentMethod(string paymentId, double paymentAmount, string paymentType)
        {
            PaymentID = paymentId;
            PaymentAmount = paymentAmount;
            PaymentType = paymentType;
        }
    }
}
