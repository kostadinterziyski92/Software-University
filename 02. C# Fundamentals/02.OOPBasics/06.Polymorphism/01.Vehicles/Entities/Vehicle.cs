using System;

public abstract class Vehicle : IDrivable, IRefuable, IFuel
{
    private double fuel;
    private double consumption;
    private double tankCapacity;

    public Vehicle(double fuel, double consumption, double tankCapacity)
    {
        this.TankCapacity = tankCapacity;
        this.Fuel = fuel;
        this.Consumption = consumption;
    }

    public double Fuel
    {
        get
        {
            return this.fuel;
        }
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            else if (value > this.TankCapacity)
            {
                this.fuel = 0;
            }
            else
            {
                this.fuel = value;
            }
        }
    }

    public double Consumption
    {
        get
        {
            return this.consumption;
        }
        protected set
        {
            this.consumption = value;
        }
    }

    public double TankCapacity
    {
        get
        {
            return tankCapacity;
        }
        set
        {
            tankCapacity = value;
        }
    }


    public abstract void Drive(double distance);

    public  abstract void Refuel(double literes);
}

