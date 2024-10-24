using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LucidMarket.Services;
using LucidMarket.Abstractions;

namespace LucidMarket.Model
{
    public class Employee : ClassExtent<Employee>
    {
        public string EmployeeID { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public double Salary { get; set; }

        public Employee(string employeeId, string name, string role, double salary)
        {
            EmployeeID = employeeId;
            Name = name;
            Role = role;
            Salary = salary;
        }
    }
}

