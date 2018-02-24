using System;
using System.Data;
using System.Linq;

namespace _04.FindEvenOrOdd
{
    class FindEvenOrOdd
    {
        static void Main()
        {
            var lowerAndUpperBound = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var lower = lowerAndUpperBound[0];
            var upper = lowerAndUpperBound[1];

            var cmd = Console.ReadLine();

            var findEvenOrOdd = OddOrEven(cmd);

            for (int i = lower; i <= upper; i++)
            {
                if (findEvenOrOdd(i))
                {
                    Console.Write(i + " ");
                }
            }
        }

        static Predicate<int> OddOrEven(string command)
        {
            if (command == "even")
            {
                return x => x % 2 == 0;
            }
            else
            {
                return x => x % 2 != 0;
            }
        }
    }
}
