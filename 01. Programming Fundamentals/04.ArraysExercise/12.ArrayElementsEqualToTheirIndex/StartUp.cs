using System;
using System.Linq;
using System.Text;

namespace _12.ArrayElementsEqualToTheirIndex
{
    class StartUp
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == i)
                {
                    stringBuilder.Append($"{i} ");
                }
            }

            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
