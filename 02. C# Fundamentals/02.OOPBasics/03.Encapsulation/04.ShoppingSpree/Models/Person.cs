using System;
using System.Collections.Generic;

public class Person
{
    private string name;
    private decimal money;
    public List<Product> BagOfProducts { get; set; }

    public Person(string name, decimal money)
    {
        this.Name = name;
        this.Money = money;
        this.BagOfProducts = new List<Product>();
    }

    public string Name
    {
        get { return this.name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"{nameof(Name)} cannot be empty");
            }
            this.name = value;
        }
    }

    public decimal Money
    {
        get { return this.money; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException($"{nameof(Money)} cannot be negative");
            }
            this.money = value;
        }
    }
}

