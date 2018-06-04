using System;

namespace _08.TravelingAtLightSpeed
{
    class TravelingAtLightSpeed
    {
        static void Main()
        {
            decimal lightYears = decimal.Parse(Console.ReadLine());

            decimal kilometers = lightYears * 9450000000000m;

            decimal speedOfLight = 300000;

            decimal seconds = kilometers / speedOfLight;

            decimal minutes = seconds / 60;
            seconds %= 60;
            decimal hours = minutes / 60;
            minutes %= 60;
            decimal days = hours / 24;
            hours %= 24;
            decimal weeks = days / 7;
            days %= 7;

            Console.WriteLine("{0} weeks", (int)weeks);
            Console.WriteLine("{0} weeks", (int)days);
            Console.WriteLine("{0} weeks", (int)hours);
            Console.WriteLine("{0} weeks", (int)minutes);
            Console.WriteLine("{0} weeks", (int)seconds);
        }
    }
}
