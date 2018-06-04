using System;

public class Car
{
    public Car(string model, decimal fuel, decimal fuelConsumption)
    {
        this.Model = model;
        this.Fuel = fuel;
        this.FuelConsumptionPerKm = fuelConsumption;
        this.DistanceTravelled = 0;
    }

    public string Model { get; set; }
    public decimal Fuel { get; set; }
    public decimal FuelConsumptionPerKm { get; set; }
    public decimal DistanceTravelled { get; set; }

    public void Drive(decimal distance)
    {
        if (this.Fuel < distance * this.FuelConsumptionPerKm)
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
        else
        {
            this.Fuel -= distance * this.FuelConsumptionPerKm;
            this.DistanceTravelled += distance;
        }
    }

    public override string ToString()
    {
        return $"{Model} {Fuel:f2} {DistanceTravelled}";
    }
}

