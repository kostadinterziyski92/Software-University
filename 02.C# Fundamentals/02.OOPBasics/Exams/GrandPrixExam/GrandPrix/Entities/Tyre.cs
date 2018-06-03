
using System;

public abstract class Tyre
{
    private double degredation;

    protected Tyre(string name, double hardness)
    {
        this.Name = name;
        this.Hardness = hardness;
        this.Degradation = 100d;
    }

    public string Name { get; }

    public double Hardness { get; protected set; }

    public virtual double Degradation
    {
        get
        {
            return this.degredation;
        }
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException(OutputMessages.BlownTyre);
            }

            this.degredation = value;
        }
    }

    public virtual void CompleteLap()
    {
        this.Degradation -= this.Hardness;
    }

}

