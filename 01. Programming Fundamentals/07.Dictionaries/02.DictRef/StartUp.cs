using System;
using System.Collections.Generic;

namespace _02.DictRef
{
    class StartUp
    {
        static void Main()
        {
            string input = String.Empty;
            var dict = new Dictionary<string, int>();

            while ((input = Console.ReadLine()) != "end")
            {
                var tokens = input.Split();

                var checkForNum = int.TryParse(tokens[tokens.Length - 1], out int value);
                var key = tokens[0];

                if (checkForNum)
                {
                    dict[key] = value;
                }
                else
                {
                    var secondKey = tokens[tokens.Length - 1];
                    if (dict.ContainsKey(secondKey))
                    {
                        dict[key] = dict[secondKey];
                    }
                }
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} === {item.Value}");
            }
        }
    }
}
