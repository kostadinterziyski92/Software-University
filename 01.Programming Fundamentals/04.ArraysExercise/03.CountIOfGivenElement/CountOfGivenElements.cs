using System;
using System.Linq;

namespace _03.CountIOfGivenElement
{
    class CountOfGivenElements
    {
        static void Main()
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var checkNum = int.Parse(Console.ReadLine());
            var counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == checkNum)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
