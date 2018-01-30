using System;

namespace _03.ExchangeVariableValues
{
    class ExchangeVariablesValues
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Old values:");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine();

            int c = a;
            a = b;
            b = c;

            Console.WriteLine("Replaced Values:");
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
