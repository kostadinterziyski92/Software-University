using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.BasicQueueOperations
{
    class BasicQueueOperations
    {
        static void Main()
        {
            var elements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var countQueue = elements[0];
            var countDeQueue = elements[1];
            var numberToFind = elements[2];
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            var secondaryQueue = new Queue<int>(numbers);
            var mainQueue = new Queue<int>();

            for (int i = 0; i < countQueue; i++)
            {
                mainQueue.Enqueue(secondaryQueue.Dequeue());
            }
            for (int i = 0; i < countDeQueue; i++)
            {
                mainQueue.Dequeue();
            }
            if (mainQueue.Contains(numberToFind))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (mainQueue.Any())
                {
                    Console.WriteLine(mainQueue.Min());
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
