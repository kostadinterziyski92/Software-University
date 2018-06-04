using System;

public class Car
{
    private const double MaxFuelAmount = 160;

    public Car(int hp, double fuelAmount, Tyre tyre)
    {
        this.Hp = hp;
        this.FuelAmount = fuelAmount;
        this.Tyre = tyre;
    }

    public int Hp { get; }

    private double fuelAmount;

    public double FuelAmount
    {
        get { return fuelAmount; }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException(OutputMessages.OutOfFuel);
            }

            this.fuelAmount = Math.Min(value, MaxFuelAmount);
        }
    }


    public Tyre Tyre { get; private set; }

    public void Refuel(double fuel)
    {
        this.FuelAmount += fuel;
    }

    public void ChangeTyres(Tyre tyre)
    {
        this.Tyre = tyre;
    }

    public void CompleteLap(int trackLength, double fuelConsumption)
    {
        this.FuelAmount -= trackLength * fuelConsumption;

        this.Tyre.CompleteLap();
    }
}

