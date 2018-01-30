using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.MaximumElement
{
    class MaximumElement
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            var strBuilder = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                var elements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                var query = elements[0];
                var number = 0;

                if (query == 1)
                {
                    number = elements[1];
                }

                switch (query)
                {
                    case 1: stack.Push(number);
                        break;
                    case 2: stack.Pop();
                        break;
                    case 3:
                        strBuilder.AppendLine(stack.Max().ToString());
                        break;
                }
            }

            Console.WriteLine(strBuilder);
        }
    }
}
