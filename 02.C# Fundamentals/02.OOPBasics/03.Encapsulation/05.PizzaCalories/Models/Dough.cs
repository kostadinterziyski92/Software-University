using System;
using System.Linq;

public class Dough
{
    private const double WhiteModifier = 1.5;
    private const double WholeGrainModifier = 1.0;
    private const double CrispyModifier = 0.9;
    private const double ChewyModifier = 1.1;
    private const double HomeMadeModifier = 1.0;

    private readonly string[] allowedFlourValues = {"white", "wholegrain"};
    private readonly string[] allowedBakingValues = {"crispy", "chewy", "homemade"};

    private string flourType;
    private string bakingTechnique;
    private double weight;

    public Dough(string flourType, string bakingTechnique, double weight)
    {
        this.FlourType = flourType;
        this.BakingTechnique = bakingTechnique;
        this.Weight = weight;
    }

    public string FlourType
    {
        get { return flourType; }
        set
        {
            if (!allowedFlourValues.Contains(value.ToLower()))
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            flourType = value;
        }
    }

    public string BakingTechnique
    {
        get { return bakingTechnique; }
        set
        {
            if (!allowedBakingValues.Contains(value.ToLower()))
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            bakingTechnique = value;
        }
    }

    public double Weight
    {
        get { return weight; }
        set
        {
            if (value < 1 || value > 200)
            {
                throw new ArgumentException("Dough weight should be in the range [1..200]");
            }
            weight = value;
        }
    }


    public double CalcDoughCalories()
    {
        double flourModifier = 0;
        
        switch (flourType.ToLower())
        {
            case "white":
                flourModifier = WhiteModifier;
                break;
            case "wholegrain":
                flourModifier = WholeGrainModifier;
                break;
        }

        double bakingModifier = 0;

        switch (bakingTechnique.ToLower())
        {
            case "crispy":
                bakingModifier = CrispyModifier;
                break;
            case "chewy":
                bakingModifier = ChewyModifier;
                break;
            case "homemade":
                bakingModifier = HomeMadeModifier;
                break;
        }

        var result = weight * 2 * flourModifier * bakingModifier;

        return result;
    }
}

