using System;

namespace _02.DateModifier
{
    class StartUp
    {
        static void Main()
        {
            var date1 = Console.ReadLine();
            var date2 = Console.ReadLine();

            global::DateModifier modifier = new global::DateModifier();
            modifier.DateDifference(date1, date2);
            Console.WriteLine(modifier.Difference);
        }
    }
}
