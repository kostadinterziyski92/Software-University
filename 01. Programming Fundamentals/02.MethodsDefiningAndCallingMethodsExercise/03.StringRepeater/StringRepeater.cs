using System;

namespace _03.StringRepeater
{
    class StringRepeater
    {
        static void Main()
        {
            RepeatedString("roki", 6);
        }

        private static void RepeatedString(string str, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(str);
            }
        }
    }
}
