using System;
using System.Linq;

namespace _01.LargestElementInArray
{
    class LargestElementInArray
    {
        static void Main()
        {
            var arraySize = int.Parse(Console.ReadLine());
            var arr = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(arr.Max());
        }
    }
}
