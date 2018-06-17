using System;
using System.Linq;

namespace _03.EqualSumAfterExtraction
{
    class StartUp
    {
        static void Main()
        {
            var list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            var list2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            foreach (var item in list1)
            {
                if (list2.Contains(item))
                {
                    list2.Remove(item);
                }
            }

            var sum1 = list1.Sum();
            var sum2 = list2.Sum();

            if (sum1 == sum2)
            {
                Console.WriteLine($"Yes. Sum: {sum1}");
            }
            else
            {
                var difference = Math.Abs(sum2 - sum1);
                Console.WriteLine($"No. Diff: {difference}");
            }
        }
    }
}
