using System;

namespace _16.TrickyStrings
{
    class TrickyStrings
    {
        static void Main()
        {
            string delimiter = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string completeWords = String.Empty;

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                completeWords += word + delimiter;
            }

            string removeLastChar = completeWords.Remove(completeWords.Length - delimiter.Length, delimiter.Length);
            Console.WriteLine($"{removeLastChar}");

        }
    }
}
