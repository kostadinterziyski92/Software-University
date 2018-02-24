using System;
using System.IO;

namespace _01.OddLines
{
    class OddLines
    {
        static void Main()
        {
            var reader = new StreamReader("text.txt");

            using (reader)
            {
                var line = reader.ReadLine();
                int lineCounter = 0;

                while (line != null)
                {
                    if (lineCounter % 2 != 0)
                    {
                        Console.WriteLine(line);
                    }

                    lineCounter++;
                    line = reader.ReadLine();
                }
            }
        }
    }
}
