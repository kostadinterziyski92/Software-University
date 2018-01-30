using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicStackOperations
{
    class BasicStackOperations
    {
        static void Main()
        {
            var elements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var numbersToPush = elements[0];
            var numbersToPop = elements[1];
            var numberToLookFor = elements[2];

            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var stack = new Stack<int>();
            var queue = new Queue<int>(numbers);

            for (int i = 0; i < numbersToPush; i++)
            {
                stack.Push(queue.Dequeue());
            }
            for (int i = 0; i < numbersToPop; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(numberToLookFor))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (stack.Any())
                {
                    Console.WriteLine(stack.Min());
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
