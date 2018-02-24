using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace _05.AppliedArithmetics
{
    class AppliedArithmetics
    {
        static void Main()
        {
            Action<List<int>> print = nums => Console.Write(string.Join(" ", nums));
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var line = string.Empty;

            while ((line = Console.ReadLine()) != "end")
            {
                
                if (line != "print")
                {
                    var calculate = ArithmeticActions(line);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        numbers[i] = calculate(numbers[i]);
                    }
                }
                else
                {
                    print(numbers);
                }
                
                
            }
        }

        static Func<int, int> ArithmeticActions(string cmd)
        {
            if (cmd == "add")
            {
                return x => x + 1;
            }
            else if (cmd == "multiply")
            {
                return x => x * 2;
            }
            else 
            {
                return x => x - 1;
            }
        }
    }
}
