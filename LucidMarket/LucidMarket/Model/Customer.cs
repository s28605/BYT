using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LucidMarket.Services;
using LucidMarket.Abstractions;

namespace LucidMarket.Model
{
    public class Customer : ClassExtent<Customer>
    {
        public string AccountID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string ShippingAddress { get; set; }
        public int LoyaltyPoints { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();

        public Customer(string accountId, string name, string email, string phoneNumber, string shippingAddress, int loyaltyPoints)
        {
            AccountID = accountId;
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            ShippingAddress = shippingAddress;
            LoyaltyPoints = loyaltyPoints;
        }
    }
}
