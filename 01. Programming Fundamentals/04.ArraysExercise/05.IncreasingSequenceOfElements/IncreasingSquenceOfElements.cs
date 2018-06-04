using System;
using System.Linq;

namespace _05.IncreasingSequenceOfElements
{
    class IncreasingSquenceOfElements
    {
        static void Main()
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] < arr[i + 1]) continue;
                
                Console.WriteLine("NO"); return; 
            }

            Console.WriteLine("YES");
        }
    }
}
