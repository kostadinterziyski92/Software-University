using System;
using System.Collections.Generic;

namespace _05.CapitalizeWords
{
    class StartUp
    {
        static void Main()
        {
            string line = String.Empty;

            while ((line = Console.ReadLine()) != "end")
            {
                var tokens = line.Split(new[] {' ', ',', '.', '/', '\\', '[', ']', '{', '}', ':', ';'
                    , '"', '-', '>', '_', '=', '|', '%', '@', '$', '*', '!', '?', '<', '#', '^', '&', '(', ')', '~', '+' }, StringSplitOptions.RemoveEmptyEntries);
                var list = new List<string>();

                foreach (var token in tokens)
                {
                    var firstLetter = char.ToUpper(token[0]);
                    var restOfWord = token.Substring(1).ToLower();
                    list.Add(firstLetter + restOfWord);
                }

                Console.WriteLine(string.Join(", ", list));
                list.Clear();
            }
        }
    }
}
