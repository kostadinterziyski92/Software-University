using System;
using System.Linq;

namespace _08.ArraySymmetry
{
    class StartUp
    {
        static void Main()
        {
            //Solution 1

            var arrOfStr = Console.ReadLine().Split();

            var i = -1;
            var j = arrOfStr.Length;

            while (j > 0)
            {
                i++;
                j--;

                if (arrOfStr[j] == arrOfStr[i]) continue;
                Console.WriteLine("No"); return;
            }

            Console.WriteLine("Yes");

            //Solution 2

            //var arrOfStr = Console.ReadLine().Split();

            //var reversedArr = arrOfStr.Reverse().ToArray();

            //if (arrOfStr.SequenceEqual(reversedArr))
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}
        }
    }
}
