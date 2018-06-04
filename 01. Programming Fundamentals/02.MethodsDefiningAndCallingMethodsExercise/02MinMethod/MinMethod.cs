using System;

namespace _02.MinMethod
{
    class MinMethod
    {
        static void Main()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            var result = GetMin(GetMin(a, b), c);
            Console.WriteLine(result);
        }

        public static int GetMin(int a, int b)
        {
            if (a > b)
            {
                return b;
            }
            else
            {
                return a;
            }
        }
    }
}
