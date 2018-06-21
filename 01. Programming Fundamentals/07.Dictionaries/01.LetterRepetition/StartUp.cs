using System;
using System.Collections.Generic;

namespace _01.LetterRepetition
{
    class StartUp
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var dict = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                var key = input[i];
                if (!dict.ContainsKey(key))
                {
                    dict[key] = 0;
                }

                dict[key]++;
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
