using System;
using System.Runtime.InteropServices;

namespace _04.NthDigit
{
    class NthDigit
    {
        static void Main()
        {
            var number = long.Parse(Console.ReadLine());
            var index = int.Parse(Console.ReadLine());
            var digitAtIndex = FindNthDigit(number, index);

            Console.WriteLine(digitAtIndex);
        }

        static int FindNthDigit(long number, int index)
        {
            var counter = 1;
            while (number > 0)
            {
                if (counter == index)
                {
                    return (int) (number % 10);
                }
                counter++;
                number /= 10;
            }

            return (int)(number % 10);
        }
    }
}
