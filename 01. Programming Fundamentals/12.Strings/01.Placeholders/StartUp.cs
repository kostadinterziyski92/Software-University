using System;

namespace _01.Placeholders
{
    class StartUp
    {
        static void Main()
        {
            var inputLine = String.Empty;

            while ((inputLine = Console.ReadLine()) != "end")
            {
                var inputParams = Console.ReadLine().Split(new []{'-', '>'}, StringSplitOptions.RemoveEmptyEntries);
                var str = inputParams[0].Trim();
                var elements = inputParams[1].Trim().Split(new []{',', ' '}, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < elements.Length; i++)
                {
                    var placeholder = "{" + i + "}";
                    str = str.Replace(placeholder, elements[i]);
                }

                Console.WriteLine(str);
            }

        }
    }
}
