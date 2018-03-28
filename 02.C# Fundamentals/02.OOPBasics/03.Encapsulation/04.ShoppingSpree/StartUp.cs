using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ShoppingSpree
{
    class StartUp
    {
        static void Main()
        {
            try
            {
                var peopleInfo = Console.ReadLine();
                var people = GetPeople(peopleInfo);

                var productsInfo = Console.ReadLine();
                var prodcts = GetProducts(productsInfo);

                var cmd = string.Empty;
                while ((cmd = Console.ReadLine()) != "END")
                {
                    var command = cmd.Split();
                    var personName = command[0];
                    var productName = command[1];

                    var currentPerson = people.FirstOrDefault(p => p.Name == personName);
                    var currentProduct = prodcts.FirstOrDefault(p => p.Name == productName);

                    if (currentPerson.Money >= currentProduct.Cost)
                    {
                        currentPerson.Money -= currentProduct.Cost;
                        currentPerson.BagOfProducts.Add(currentProduct);
                        Console.WriteLine($"{currentPerson.Name} bought {currentProduct.Name}");
                    }
                    else
                    {
                        Console.WriteLine($"{currentPerson.Name} can't afford {currentProduct.Name}");
                    }
                }

                PrintPurchases(people);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            
        }

        private static void PrintPurchases(List<Person> people)
        {
            foreach (var person in people)
            {
                if (person.BagOfProducts.Count > 0)
                {
                    Console.WriteLine("{0} - {1}", person.Name, string.Join(", ", person.BagOfProducts.Select(p => p.Name)));
                }
                else
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
            }
        }

        private static List<Product> GetProducts(string productsInfo)
        {
            var products = new List<Product>();

            var productsArgs = productsInfo.Split(new[] {';'}, StringSplitOptions.RemoveEmptyEntries);
            foreach (var token in productsArgs)
            {
                var product = token.Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                var name = product[0];
                var cost = decimal.Parse(product[1]);

                products.Add(new Product(name, cost));
            }

            return products;
        }

        private static List<Person> GetPeople(string peopleInfo)
        {
            var people = new List<Person>();

            var peopleArgs = peopleInfo.Split(new[] {';'}, StringSplitOptions.RemoveEmptyEntries);
            foreach (var token in peopleArgs)
            {
                var person = token.Split(new[] {'='}, StringSplitOptions.RemoveEmptyEntries);
                var name = person[0];
                var money = decimal.Parse(person[1]);

                people.Add(new Person(name, money));
            }

            return people;
        }
    }
}
