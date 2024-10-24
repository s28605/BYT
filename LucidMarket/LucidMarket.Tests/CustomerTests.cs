using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LucidMarket.Model;

namespace LucidMarket.Tests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void Customer_Initialization_ShouldSetProperties()
        {
            string accountId = "BRUCE001";
            string name = "Bruce Wayne";
            string email = "brc@wayneenterprises.com";
            string phoneNumber = "525-1938";
            string shippingAddress = "Bovery 52, Gotham";
            int loyaltyPoints = 5000;

            var customer = new Customer(accountId, name, email, phoneNumber, shippingAddress, loyaltyPoints);

            Assert.AreEqual(accountId, customer.AccountID);
            Assert.AreEqual(name, customer.Name);
            Assert.AreEqual(email, customer.Email);
            Assert.AreEqual(phoneNumber, customer.PhoneNumber);
            Assert.AreEqual(shippingAddress, customer.ShippingAddress);
            Assert.AreEqual(loyaltyPoints, customer.LoyaltyPoints);
        }

        [TestMethod]
        public void Customer_LoyaltyPoints_ShouldUpdatePoints()
        {
            var customer = new Customer("KENT001", "Clark Kent", "clark@dailyplanet.com", "555-2103", "Metropolis", 1000);

            customer.LoyaltyPoints += 500;

            Assert.AreEqual(1500, customer.LoyaltyPoints);
        }
    }
}
