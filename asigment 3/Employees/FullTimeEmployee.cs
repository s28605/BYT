namespace assignment3;

public class FullTimeEmployee : Employee
{
    public DateTime ShiftStartTime { get; set; }
    public DateTime ShiftEndTime { get; set; }
    public TimeSpan ShiftTime => ShiftEndTime - ShiftStartTime; // Calculated property
}
