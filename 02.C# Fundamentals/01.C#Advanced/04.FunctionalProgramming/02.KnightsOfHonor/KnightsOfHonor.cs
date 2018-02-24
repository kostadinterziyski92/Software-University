using System;
using System.Linq;

namespace _02.KnightsOfHonor
{
    class KnightsOfHonor
    {
        static void Main()
        {
            var names = Console.ReadLine().Split(' ').ToList();

            Action<string> print = s => Console.WriteLine($"Sir {s}");

            names.ForEach(print);
        }
    }
}
