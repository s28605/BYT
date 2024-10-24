using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LucidMarket.Services;
using LucidMarket.Abstractions;

namespace LucidMarket.Model
{
    public class Review : ClassExtent<Review>
    {
        public string ReviewID { get; set; }
        public string CustomerID { get; set; }
        public Product Product { get; set; }
        public double Rating { get; set; }
        public string Comment { get; set; }

        public Review(string reviewId, string customerId, Product product, double rating, string comment)
        {
            ReviewID = reviewId;
            CustomerID = customerId;
            Product = product;
            Rating = rating;
            Comment = comment;
        }
    }
}

