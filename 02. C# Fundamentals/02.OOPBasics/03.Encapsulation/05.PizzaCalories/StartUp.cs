using System;
using System.Collections.Generic;

namespace _05.PizzaCalories
{
    class StartUp
    {
        static void Main()
        {
            try
            {
                int numberOfToppings = 0;
                var tokens = Console.ReadLine().Split();
                var pizza = new Pizza(tokens[1]);

                var line = string.Empty;

                while ((line = Console.ReadLine()) != "END")
                {
                    tokens = line.Split();
                    if (tokens[0] == "Dough")
                    {
                        var dough = new Dough(tokens[1], tokens[2], double.Parse(tokens[3]));
                        pizza.Dough = dough;
                    }
                    else
                    {
                        var topping = new Topping(tokens[1], double.Parse(tokens[2]));
                        pizza.AddTopping(topping);
                        numberOfToppings++;
                    }

                }
                pizza.NumberOfToppings = numberOfToppings;

                Console.WriteLine($"{pizza.Name} - {pizza.GetTotalCalories():f2} Calories.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
