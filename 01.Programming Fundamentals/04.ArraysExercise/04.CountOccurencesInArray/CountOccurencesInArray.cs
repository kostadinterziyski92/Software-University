using System;
using System.Linq;

namespace _04.CountOccurencesInArray
{
    class CountOccurencesInArray
    {
        static void Main()
        {
            var arr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var chekNum = double.Parse(Console.ReadLine());
            var counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > chekNum)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
