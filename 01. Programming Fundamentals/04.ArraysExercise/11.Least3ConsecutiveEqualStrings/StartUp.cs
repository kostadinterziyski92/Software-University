using System;
using System.Collections.Generic;

namespace _11.Least3ConsecutiveEqualStrings
{
    class StartUp
    {
        static void Main()
        {
            var input = Console.ReadLine().Split();
            var arr = new string[3];

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1] && input[i + 1] == input[i + 2])
                {
                    Array.Clear(arr, 0, 2);

                    arr[0] = input[i];
                    arr[1] = input[i + 1];
                    arr[2] = input[i + 2];
                }
            }

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
