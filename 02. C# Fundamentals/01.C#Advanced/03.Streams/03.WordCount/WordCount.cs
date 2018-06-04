using System;
using System.IO;
using System.Linq;
using System.Linq.Expressions;

namespace _03.WordCount
{
    class WordCount
    {
        static void Main()
        {
            var readerWords = new StreamReader("words.txt");
            var readerText = new StreamReader("text.txt");
            var writer = new StreamWriter("result.txt");

            using (readerText)
            {
                using (readerWords)
                {
                    using (writer)
                    {
                        
                    }
                }
            }
        }
    }
}
