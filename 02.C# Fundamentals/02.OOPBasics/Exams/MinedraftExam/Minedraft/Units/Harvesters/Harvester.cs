using System;

public abstract class Harvester : Unit
{
    private const double MaxEnergyValue = 20_000;

    private double oreOutput;
    private double energyRequirement;

    protected Harvester(string id, double oreOutput, double energyRequirement)
        :base(id)
    {
        this.OreOutput = oreOutput;
        this.EnergyRequirement = energyRequirement;
    }

    public string Id { get; }


    public double OreOutput
    {
        get { return oreOutput; }
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException("Harvester is not registered, because of it's OreOutput");
            }
            oreOutput = value;
        }
    }

    public double EnergyRequirement
    {
        get { return energyRequirement; }
        protected set
        {
            if (value < 0 && value > MaxEnergyValue)
            {
                throw new ArgumentException("Harvester is not registered, because of it's EnergyRequirement");
            }
            energyRequirement = value;
        }
    }

    public override string ToString()
    {
        var result = $"{Type} Harvester - {Id}" + Environment.NewLine +
                     $"Ore Output: {OreOutput}" + Environment.NewLine +
                     $"Energy Requirement: {EnergyRequirement}";

        return result;
    }
}

