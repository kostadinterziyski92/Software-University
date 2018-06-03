using System;

public abstract class Provider : Unit
{
    private const double MaxEnergyOutput = 10_000;

    private double energyOutput;

    protected Provider(string id, double energyOutput)
        :base(id)
    {
        this.EnergyOutput = energyOutput;
    }

    public string Id { get; set; }

    public double EnergyOutput
    {
        get { return energyOutput; }
        protected set
        {
            if (value < 0 && value > MaxEnergyOutput)
            {
                throw new ArgumentException("Provider is not registered, because of it's EnergyOutput");
            }
            energyOutput = value;
        }
    }

    public override string ToString()
    {
        var result = $"{Type} Provider - {Id}" + Environment.NewLine +
                     $"Energy Output: {EnergyOutput}";

        return result;
    }
}

