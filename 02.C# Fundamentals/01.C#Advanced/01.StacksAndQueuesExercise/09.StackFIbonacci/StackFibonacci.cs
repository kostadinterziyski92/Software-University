using System;
using System.Collections.Generic;

namespace _09.StackFIbonacci
{
    class StackFibonacci
    {
        static void Main()
        {
            var nthNumber = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            stack.Push(0);
            stack.Push(1);
            

            for (int i = 0; i < nthNumber - 1; i++)
            {
                var popedNum = stack.Pop();
                var peekedNum = stack.Peek();
                var sum = popedNum + peekedNum;
                
                stack.Push(popedNum);
                stack.Push(sum);
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
