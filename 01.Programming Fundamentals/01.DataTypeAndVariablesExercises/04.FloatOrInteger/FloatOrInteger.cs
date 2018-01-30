using System;

namespace _04.FloatOrInteger
{
    class FloatOrInteger
    {
        static void Main()
        {
            double input = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Round(input));
        }
    }
}
