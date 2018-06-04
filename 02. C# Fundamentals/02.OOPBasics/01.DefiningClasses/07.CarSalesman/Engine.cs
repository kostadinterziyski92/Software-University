public class Engine
{
    public Engine(string model, int power)
    {
        this.Model = model;
        this.Power = power;
        this.Displacement = 0;
        this.Efficiency = "n/a";
    }

    public Engine(string model, int power, double displacement)
        :this(model, power)
    {
        this.Displacement = displacement;
    }

    public Engine(string model, int power, string efficiency)
        : this(model, power)
    {
        this.Efficiency = efficiency;
    }

    public Engine(string model, int power, double displacement, string efficiency)
        : this(model, power)
    {
        this.Displacement = displacement;
        this.Efficiency = efficiency;
    }

    public string Model { get; set; }

    public int Power { get; set; }

    public double Displacement { get; set; }

    public string Efficiency { get; set; }

}