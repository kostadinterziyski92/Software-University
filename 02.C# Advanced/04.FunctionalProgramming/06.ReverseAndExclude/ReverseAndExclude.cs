using System;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class ReverseAndExclude
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(new string[]{" "}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse);
            var divisable = int.Parse(Console.ReadLine());
            Func<int, bool> IsItDivisable = n => n % divisable != 0;

            var remainingNumbers = numbers.Reverse().Where(IsItDivisable);
            
            Console.WriteLine(string.Join(" ", remainingNumbers));

        }

        
    }
}
