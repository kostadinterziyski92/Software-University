using System;
using System.Collections.Generic;

namespace _01.RemoveElementsAtOddPositions
{
    class StartUp
    {
        static void Main()
        {
            var input = Console.ReadLine().Split();
            var resultList = new List<string>();

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (i % 2 != 0)
                {
                    resultList.Add(input[i]);
                }
            }

            foreach (var result in resultList)
            {
                Console.Write(result);
            }

            Console.WriteLine();
        }
    }
}
