using System;

namespace _02.DateModifierTask
{
    class StartUp
    {
        static void Main()
        {
            var date1 = Console.ReadLine();
            var date2 = Console.ReadLine();

            DateModifier modifier = new DateModifier();
            modifier.DateDifference(date1, date2);
            Console.WriteLine(modifier.Difference);
        }
    }
}
