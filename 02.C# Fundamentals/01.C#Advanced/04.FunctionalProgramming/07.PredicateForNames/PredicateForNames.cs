using System;
using System.Linq;

namespace _07.PredicateForNames
{
    class PredicateForNames
    {
        static void Main()
        {
            var lenght = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split(' ').ToArray();

            Func<string, bool> NameLenght(int len)
            {
                return x => x.Length <= len;
            };

            names.Where(NameLenght(lenght)).ToList().ForEach(s => Console.WriteLine(s));
        }
    }
}
