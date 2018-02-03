using System;

namespace _07.FromTerabytesToBits
{
    class FromTerabytesToBits
    {
        static void Main()
        {
            decimal input = decimal.Parse(Console.ReadLine());

            decimal terabytesToBits = 1024m * 1024 * 1024 * 1024 * 8;

            decimal convertResult = input * terabytesToBits;

            Console.WriteLine(convertResult);
        }
    }
}
