using System;
using System.Text;

public class Worker : Human
{
    private const int WORK_DAYS_PER_WEEK = 5;

    private decimal weekSalary;
    private int workHoursPerDay;

    public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
        :base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursPerDay;
    }

    public decimal WeekSalary
    {
        get
        {
            return weekSalary;
        }
        protected set 
        {
            if (value <= 10)
            {
                throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
            }
            weekSalary = value;
        }
    }
    
    public int WorkHoursPerDay
    {
        get
        {
            return workHoursPerDay;
        }
        protected set 
        {
            if (value < 1 || value > 12)
            {
                throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
            }
            workHoursPerDay = value;
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"First Name: {this.FirstName}");
        sb.AppendLine($"Last Name: {this.LastName}");
        sb.AppendLine($"Week Salary: {this.WeekSalary:f2}");
        sb.AppendLine($"Hours per day: {this.WorkHoursPerDay:f2}");
        sb.AppendLine($"Salary per hour: {(this.WeekSalary / WORK_DAYS_PER_WEEK / this.WorkHoursPerDay):f2}");

        return sb.ToString();
    }
}