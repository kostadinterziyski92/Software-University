using System;
using System.Runtime.InteropServices;

public class Car : Vehicle
{
    private const double SummerConsumptionIncrease = 0.9;
    private const string InsufficientFuel = "Car needs refueling";

    public Car(double fuel, double consumption, double tankCapacity): base(fuel, consumption, tankCapacity) { }

    public override void Drive(double distance)
    {
        var newConsumption = Consumption + SummerConsumptionIncrease;
        if (distance * newConsumption > this.Fuel)
        {
            Console.WriteLine(InsufficientFuel);
        }
        else
        {
            this.Fuel -= distance * newConsumption;
            Console.WriteLine($"Car travelled {distance} km");
        }
    }

    public override void Refuel(double literes)
    {
        if (literes <= 0)
        {
            Console.WriteLine("Fuel must be a positive number");
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

