using System;

namespace _14.ASCIIString
{
    class ASCIIString
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string word = String.Empty;

            for (int i = 0; i < n; i++)
            {
                int asci = int.Parse(Console.ReadLine());
                char character = (char) asci;
                word += character;
            }

            Console.WriteLine(word);
        }
    }
}
