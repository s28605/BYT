using LucidMarket.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucidMarket.Model.Employees
{
    public class FullTimeEmployee : ClassExtent<FullTimeEmployee>    
    {
        public DateTime ShiftStartTime { get; set; }
        public DateTime ShiftEndTime { get; set; }
        public TimeSpan ShiftTime => ShiftEndTime - ShiftStartTime;
    }
}
