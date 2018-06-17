using System;

namespace _07.CountOfCapitalLettersInArray
{
    class StartUp
    {
        static void Main()
        {
            var arrOfStr = Console.ReadLine().Split();
            var count = 0;

            foreach (var str in arrOfStr)
            {
                if (str.Length == 1 && str == str.ToUpper())
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
