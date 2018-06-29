using System;

namespace _04.SentenceSplit
{
    class StartUp
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var delimeter = Console.ReadLine();

            var inputSplit = input.Split(delimeter);

            Console.WriteLine("[" + string.Join(", ", inputSplit) + "]");
        }
    }
}
