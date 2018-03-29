using System;

public class DateModifier
{
    private double difference;

    public double Difference
    {
        get { return this.difference; }
    }

    public void DateDifference(string date1, string date2)
    {
        DateTime d1 = DateTime.ParseExact(date1, "yyyy MM dd", null);
        DateTime d2 = DateTime.ParseExact(date2, "yyyy MM dd", null);

        var result = Math.Abs((d1 - d2).TotalDays);
        this.difference = result;
    }
}

