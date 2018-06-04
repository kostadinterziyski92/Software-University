using System.Xml.Schema;

public class Car
{
    public Car()
    {
        
    }

    public Car(string model, Engine engine)
    {
        this.Model = model;
        this.Engine = engine;
        this.Weight = 0;
        this.Color = "n/a";
    }

    public Car(string model, Engine engine, int weight)
        : this(model, engine)
    {
        this.Weight = weight;
    }

    public Car(string model, Engine engine, string color)
        : this(model, engine)
    {
        this.Color = color;
    }

    public Car(string model, Engine engine, int weight, string color)
        : this(model, engine)
    {
        this.Weight = weight;
        this.Color = color;
    }


    public string Model { get; set; }

    public Engine Engine { get; set; }

    public int Weight { get; set; }

    public string Color { get; set; }


    public override string ToString()
    {
        var formatedWeight = (this.Weight == 0 ? "n/a" : this.Weight.ToString());
        var formatedDisplacement = (this.Engine.Displacement == 0 ? "n/a" : this.Engine.Displacement.ToString());

        return $"{this.Model}:\n" +
               $"  {this.Engine.Model}:\n" +
               $"    Power: {this.Engine.Power}\n" +
               $"    Displacement: {formatedDisplacement}\n" +
               $"    Efficiency: {this.Engine.Efficiency}\n" +
               $"  Weight: {formatedWeight}\n" +
               $"  Color: {this.Color}";
    }
}


