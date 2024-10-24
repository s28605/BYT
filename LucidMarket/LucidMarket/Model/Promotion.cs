using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LucidMarket.Services;
using LucidMarket.Abstractions;

namespace LucidMarket.Model
{
    public class Promotion : ClassExtent<Promotion>
    {
        public string PromotionID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double DiscountPercentage { get; set; }

        public Promotion(string promotionId, DateTime startDate, DateTime endDate, double discountPercentage)
        {
            PromotionID = promotionId;
            StartDate = startDate;
            EndDate = endDate;
            DiscountPercentage = discountPercentage;
        }
    }
}
