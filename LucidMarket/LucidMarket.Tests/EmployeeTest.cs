using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LucidMarket.Model;

namespace LucidMarket.Tests
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void Employee_Initialization_ShouldSetProperties()
        {
            string employeeId = "E001";
            string name = "Tim Drake";
            string role = "Developer";
            double salary = 50000;

            var employee = new Employee(employeeId, name, role, salary);

            Assert.AreEqual(employeeId, employee.EmployeeID);
            Assert.AreEqual(name, employee.Name);
            Assert.AreEqual(role, employee.Role);
            Assert.AreEqual(salary, employee.Salary);
        }

        [TestMethod]
        public void Employee_SetSalary_ShouldUpdateSalary()
        {
            var employee = new Employee("E002", "Richard Grayson", "Manager", 52000);

            employee.Salary = 70000;

            Assert.AreEqual(70000, employee.Salary);
        }
    }
}
