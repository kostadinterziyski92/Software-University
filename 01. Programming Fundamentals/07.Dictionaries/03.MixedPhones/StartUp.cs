using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace _03.MixedPhones
{
    class StartUp
    {
        static void Main()
        {
            var dict = new Dictionary<string, decimal>();
            string line = String.Empty;

            while ((line = Console.ReadLine()) != "Over")
            {
                var tokens = line.Split();
                var name = tokens[0];
                var check = decimal.TryParse(tokens[tokens.Length - 1], out decimal phoneNumber);

                if (check)
                {
                    dict[name] = phoneNumber;
                }
                else
                {
                    var value = decimal.Parse(tokens[0]);
                    var key = tokens[tokens.Length - 1];

                    dict[key] = value;
                }
            }

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
