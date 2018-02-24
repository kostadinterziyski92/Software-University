using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ListOfPredicates
{
    class ListOfPredicates
    {
        static void Main()
        {
            var range = int.Parse(Console.ReadLine());
            var dividers = Console.ReadLine().Split(' ').Select(int.Parse).Distinct().ToList();
            var resultList = new List<int>();

            for (int i = 1; i <= range; i++)
            {
                    if (DivisionInfo(i, dividers))
                    {
                        resultList.Add(i);
                    }
            }

            Console.WriteLine(string.Join(" ", resultList));
        }

        static bool DivisionInfo(int n, List<int> dividers)
        {
            var isTrue = true;
            foreach (var divider in dividers)
            {
                if (n % divider != 0)
                {
                    isTrue = false;
                }
            }
            return isTrue;
        }
    }
}
