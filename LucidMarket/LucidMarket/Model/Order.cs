using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LucidMarket.Services;
using LucidMarket.Abstractions;

namespace LucidMarket.Model
{
    public class Order : ClassExtent<Order>
    {
        public string OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalAmount { get; set; }
        public string DeliveryStatus { get; set; }
        public Customer Customer { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();

        public Order(string orderId, DateTime orderDate, double totalAmount, string deliveryStatus, Customer customer)
        {
            OrderID = orderId;
            OrderDate = orderDate;
            TotalAmount = totalAmount;
            DeliveryStatus = deliveryStatus;
            Customer = customer;
        }
    }
}

