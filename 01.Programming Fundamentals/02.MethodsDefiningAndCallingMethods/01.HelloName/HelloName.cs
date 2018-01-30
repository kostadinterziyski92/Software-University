using System;

namespace _01.HelloName
{
    class HelloName
    {
        static void Main()
        {
            PrintName("Peter");
        }

        public static void PrintName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
