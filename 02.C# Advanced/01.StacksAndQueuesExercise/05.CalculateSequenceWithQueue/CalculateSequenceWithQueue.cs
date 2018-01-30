using System;
using System.Collections.Generic;
using System.Text;

namespace _05.CalculateSequenceWithQueue
{
    class CalculateSequenceWithQueue
    {
        static void Main()
        {
            long num = long.Parse(Console.ReadLine());

            Queue<long> queue = new Queue<long>();
            StringBuilder result = new StringBuilder();

            queue.Enqueue(num);
            int count = 1;

            while (count <= 50)
            {

                var firstNum = queue.Peek();

                queue.Enqueue(firstNum + 1);
                queue.Enqueue(2 * firstNum + 1);
                queue.Enqueue(firstNum + 2);

                result.Append(queue.Dequeue() + " ");
                count++;
            }

            Console.WriteLine(result);
        }
    }
}
