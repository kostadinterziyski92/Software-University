using System;

namespace _06.IncrementVariable
{
    class IncrementVariable
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int overflows = 0;
            byte number = 0;

            for (int i = 0; i < input; i++)
            {
                number++;

                if (number == 0)
                {
                    overflows++;
                }
            }

            Console.WriteLine(number);

            if (overflows > 0)
            {
                Console.WriteLine($"Overflowed {overflows} times");
            }
        }
    }
}
