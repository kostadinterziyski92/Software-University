using System;
using System.IO;

namespace _02.LineNumbers
{
    class LineNumbers
    {
        static void Main()
        {
            var reader = new StreamReader("text.txt");
            var writer = new StreamWriter("otput.txt");
            int lineNumber = 1;

            using (reader)
            {
                using (writer)
                {
                    var line = reader.ReadLine();

                    while (line != null)
                    {
                        for (int i = 0; i < line.Length; i++)
                        {
                            writer.Write($"Line {lineNumber}: {line}");
                            writer.Write(line[i]);
                        }
                        writer.WriteLine();
                        line = reader.ReadLine();
                        lineNumber++;
                    }
                    
                }
            }
        }
    }
}
