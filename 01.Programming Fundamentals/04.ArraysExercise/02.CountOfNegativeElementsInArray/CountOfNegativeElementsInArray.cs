using System;

namespace _02.CountOfNegativeElementsInArray
{
    class CountOfNegativeElementsInArray
    {
        static void Main()
        {
            var arraySize = int.Parse(Console.ReadLine());
            var arr = new int[arraySize];
            var counter = 0;

            for (int i = 0; i < arraySize; i++)
            {
                var input = int.Parse(Console.ReadLine());
                if (input < 0)
                {
                    arr[i] = input;
                    counter++;
                }
                else
                {
                    arr[i] = input;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
