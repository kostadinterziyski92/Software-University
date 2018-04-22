using System;
using System.Collections.Generic;
using System.Linq;

public class Pizza
{
    private string name;
    private Dough dough;
    private readonly List<Topping> toppings;
    private int numberOfToppings;

    public Pizza(string name)
    {
        this.Name = name;
        this.NumberOfToppings = numberOfToppings;
        this.toppings = new List<Topping>();
    }

    public Dough Dough
    {
        set => this.dough = value;
    }

    public string Name
    {
        get { return name; }
        set
        {
            if (value.Length < 1 || value.Length > 15)
            {
                throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
            }
            name = value;
        }
    }
    

    public int NumberOfToppings
    {
        get { return numberOfToppings; }
        set
        {
            if (value < 0 || value > 10)
            {
                throw new ArgumentException("Number of toppings should be in range [1..10].");
            }
            numberOfToppings = value;
        }
    }

    public void AddTopping(Topping topping)
    {
        this.toppings.Add(topping);
    }

    public double GetTotalCalories()
    {
        var totalCalories = this.dough.CalcDoughCalories() + this.toppings.Sum(t => t.CalcToppingCalories());
        return totalCalories;
    }
}

