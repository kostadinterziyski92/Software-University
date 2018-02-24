using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CustomComparator
{
    class CustomComparator
    {
        static void Main()
        {
            Func<int, bool> CheckEven = n => n % 2 == 0;

            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var even = numbers.Where(CheckEven).ToArray();
            var odd = numbers.Where(n => !CheckEven(n)).ToArray();

            
            Array.Sort(even);
            Array.Sort(odd);

            Console.WriteLine(string.Join(" ", even) + " " + string.Join(" ", odd));
        }
    }
}
