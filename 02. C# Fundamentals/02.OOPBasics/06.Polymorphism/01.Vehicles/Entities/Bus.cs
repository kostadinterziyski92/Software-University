using System;

public class Bus : Vehicle
{
    private const string InsufficientFuel = "Bus needs refueling";
    private const double AirConditioningConsumptionIncrease = 1.4;

    public Bus(double fuel, double consumption, double tankCapacity) : base(fuel, consumption, tankCapacity) { }

    public override void Drive(double distance)
    {
        var newConsumption = Consumption * AirConditioningConsumptionIncrease;
        if (distance * newConsumption > this.Fuel)
        {
            Console.WriteLine(InsufficientFuel);
        }
        else
        {
            this.Fuel -= distance * newConsumption;
            Console.WriteLine($"Bus travelled {distance} km");
        }
    }

    public void DriveEmpty(double distance)
    {
        var newConsumption = Consumption;
        if (distance * newConsumption > this.Fuel)
        {
            Console.WriteLine(InsufficientFuel);
        }
        else
        {
            this.Fuel -= distance * newConsumption;
            Console.WriteLine($"Bus travelled {distance} km");
        }
    }

    public override void Refuel(double literes)
    {
        if (literes <= 0)
        {
            Console.WriteLine("Fuel must be  a positive number");
        }
        else
        {
            var totalFuel = literes + this.Fuel;
            if (totalFuel > this.TankCapacity)
            {
                Console.WriteLine($"Cannot fit {literes} fuel in the tank");
            }
            else
            {
                this.Fuel += literes;
            }
        }
    }
}

