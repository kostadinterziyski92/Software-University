using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Telephony
{
    class StartUp
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ');
            var urls = Console.ReadLine().Split(' ');

            var smartphone = new Smartphone();
            foreach (var number in numbers)
            {
                Console.WriteLine(smartphone.Call(number));
            }

            foreach (var url in urls)
            {
                Console.WriteLine(smartphone.Browse(url));
            }

        }

    }
}
