using System;
using System.Collections.Generic;

namespace _04.ExamShopping
{
    class StartUp
    {
        static void Main()
        {
            string line = String.Empty;
            var inventory = new Dictionary<string, int>();

            while ((line = Console.ReadLine()) != "shopping time")
            {
                var tokens = line.Split();
                var productName = tokens[1];
                var productQuantity = int.Parse(tokens[2]);

                if (inventory.ContainsKey(productName))
                {
                    inventory[productName] += productQuantity;
                }
                else
                {
                    inventory.Add(productName, productQuantity);
                }
            }

            while ((line = Console.ReadLine()) != "exam time")
            {
                var tokens = line.Split();
                var productName = tokens[1];
                var productQuantity = int.Parse(tokens[2]);

                if (inventory.ContainsKey(productName) && inventory[productName] >= productQuantity)
                {
                    inventory[productName] -= productQuantity;
                }
                else if (inventory.ContainsKey(productName) && inventory[productName] == 0)
                {
                    Console.WriteLine($"{productName} out of stock");
                }
                else if (!inventory.ContainsKey(productName))
                {
                    Console.WriteLine($"{productName} doesn't exist");
                }
            }

            foreach (var product in inventory)
            {
                if (product.Value != 0)
                {
                    Console.WriteLine($"{product.Key} -> {product.Value}");
                }
            }
        }
    }
}
