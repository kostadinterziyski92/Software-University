using System;
using System.Linq;
using System.Text;

namespace _13.Phonebook
{
    class StartUp
    {
        static void Main()
        {
            var phoneNumbers = Console.ReadLine().Split();
            var names = Console.ReadLine().Split();
            StringBuilder stringBuilder = new StringBuilder();

            string name = String.Empty;

            while ((name = Console.ReadLine()) != "done")
            {
                if (names.Contains(name))
                {
                    int nameIndex = Array.IndexOf(names, name);
                    stringBuilder.AppendLine($"{name} -> {phoneNumbers[nameIndex]}");
                }
            }

            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
