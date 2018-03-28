using System;
using System.Collections.Generic;
using System.Linq;

public class Person
{
    public Person(string name)
    {
        this.Name = name;
        this.Pokemons = new List<Pokemon>();
        this.Children = new List<Person>();
        this.Parents = new List<Person>();
    }

    public Person(string name, string birhtday)
        :this(name)
    {
        this.Birthday = birhtday;
    }

    public Person(string name, Company company)
        : this(name)
    {
        this.Company = company;
    }

    public Person(string name, Car car)
        :this(name)
    {
        this.Car = car;
    }
    

    public string Name { get; set; }

    public string Birthday { get; set; }

    public Company Company { get; set; }

    public List<Pokemon> Pokemons { get; set; }

    public List<Person> Parents { get; set; }

    public List<Person> Children { get; set; }

    public Car Car { get; set; }


    //public override string ToString()
    //{
    //    return $"{this.Name}\n" +
    //           $"Company:\n" +
    //           $"{this.Company}\n" +
    //           $"Car:\n" +
    //           $"{this.Car}\n" +
    //           $"Pokemon:\n" +
    //           $"{this.Pokemons.ForEach(p=>Console.WriteLine(p))}\n" +
    //           $"Parents:\n" +
    //           $"{Parents.ForEach(p => Console.WriteLine($"{p.Name} {p.Birthday}"))}\n" +
    //           $"Children:\n" +
    //           $"{string.Join("", this.Children)}";
    //}
}

