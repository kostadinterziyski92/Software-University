using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Google
{
    class StartUp
    {
        static void Main()
        {
            var people = new List<Person>();
            var input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                var personArgs = input.Split();

                var personName = personArgs[0];
                if (!people.Any(p => p.Name == personName))
                {
                    people.Add(new Person(personName));
                }

                var action = personArgs[1];
                var person = people.Where(p => p.Name == personName).First();

                switch (action)
                {
                    case "company":
                        var companyName = personArgs[2];
                        var department = personArgs[3];
                        var salary = decimal.Parse(personArgs[4]);
                        person.Company = new Company(companyName, department, salary);
                        break;
                    case "pokemon":
                        var pokemonName = personArgs[2];
                        var pokemonType = personArgs[3];
                        person.Pokemons.Add(new Pokemon(pokemonName, pokemonType));
                        break;
                    case "parents":
                        var parentName = personArgs[2];
                        var parentBirthday = personArgs[3];
                        person.Parents.Add(new Person(parentName, parentBirthday));
                        break;
                    case "children":
                        var childName = personArgs[2];
                        var childBirthday = personArgs[3];
                        person.Children.Add(new Person(childName, childBirthday));
                        break;
                    case "car":
                        var model = personArgs[2];
                        var speed = int.Parse(personArgs[3]);
                        person.Car = new Car(model, speed);
                        break;
                }
            }

            string print = Console.ReadLine();

            var personToPrint = people.Where(p => p.Name == print).First();
            

            Console.WriteLine(personToPrint.Name);
            Console.WriteLine("Company:");
            if (personToPrint.Company != null)
            {
                Console.WriteLine(personToPrint.Company);
            }
            Console.WriteLine("Car:");
            if (personToPrint.Car != null)
            {
                Console.WriteLine(personToPrint.Car);
            }
            Console.WriteLine("Pokemon:");
            personToPrint.Pokemons.ForEach(p => Console.WriteLine(p));
            Console.WriteLine("Parents:");
            personToPrint.Parents.ForEach(p => Console.WriteLine($"{p.Name} {p.Birthday}"));
            Console.WriteLine("Children:");
            personToPrint.Children.ForEach(c => Console.WriteLine($"{c.Name} {c.Birthday}"));
        }
    }
    }
