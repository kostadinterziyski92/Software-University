using System;
using System.Linq;

namespace _04.FlipListSides
{
    class StartUp
    {
        static void Main()
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 1; i < list.Count / 2; i++)
            {
                var placeholder = 0;
                placeholder = list[i];
                list[i] = list[list.Count - i - 1];
                list[list.Count - i - 1] = placeholder;
            }

            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
