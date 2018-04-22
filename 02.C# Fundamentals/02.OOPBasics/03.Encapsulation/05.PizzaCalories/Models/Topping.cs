using System;
using System.Linq;

public class Topping
{
    private const double MeatModifier = 1.2;
    private const double VeggiesModifier = 0.8;
    private const double CheeseModifier = 1.1;
    private const double SauceModifier = 0.9;

    private readonly string[] allowedTypes = {"meat", "veggies", "cheese", "sauce"};

    private string type;
    private double weight;

    public Topping(string type, double weight)
    {
        this.Type = type;
        this.Weight = weight;
    }

    public string Type
    {
        get { return type; }
        set
        {
            if (!allowedTypes.Contains(value.ToLower()))
            {
                throw new ArgumentException($"Cannot place {value} on top of your pizza.");
            }
            type = value;
        }
    }

    public double Weight
    {
        get { return weight; }
        set
        {
            if (value < 1 || value > 50)
            {
                throw new ArgumentException($"{this.type} weight should be in the range [1..50].");
            }
            weight = value;
        }
    }

    public double CalcToppingCalories()
    {
        double toppingModifier = 0;

        switch (type.ToLower())
        {
            case "meat":
                toppingModifier = MeatModifier;
                break;
            case "veggies":
                toppingModifier = MeatModifier;
                break;
            case "cheese":
                toppingModifier = MeatModifier;
                break;
            case "sauce":
                toppingModifier = MeatModifier;
                break;
        }

        var result = 2 * weight * toppingModifier;
        return result;
    }
}

