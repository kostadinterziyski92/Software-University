using System;
using System.Text;

namespace _17.CypherRoulette
{
    class CypherRoulette
    {
        static void Main()
        {
            var strCount = int.Parse(Console.ReadLine());
            var builder = new StringBuilder();

            for (int i = 0; i < strCount; i++)
            {
                var str = Console.ReadLine();
                if (str != "spin")
                {
                    builder.Append(str);
                }
                else
                {
                    builder.Insert(0, str);
                }
            }
            Console.WriteLine(builder);
        }
    }
}
