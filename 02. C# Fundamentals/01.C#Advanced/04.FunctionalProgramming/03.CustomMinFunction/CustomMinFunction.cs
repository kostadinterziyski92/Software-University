using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace _03.CustomMinFunction
{
    class CustomMinFunction
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            
            Func<List<int>, int> minNumber = (List<int> list) =>
            {
                var min = int.MaxValue;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] < min)
                    {
                        min = list[i];
                    }
                }
                return min;
            };

            var getMin = minNumber(numbers);
            Console.WriteLine(getMin);
        }
    }
}
