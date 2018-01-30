using System;

namespace _05.DistanceOfTheStars
{
    class DistanceOfTheStars
    {
        static void Main()
        {
            decimal distance1 = 4.22m * 9450000000000m;
            decimal distance2 = 26000m * 9450000000000m;
            decimal distance3 = 100000m * 9450000000000m;
            decimal distance4 = 46500000000m * 9450000000000m;



            Console.WriteLine(distance1.ToString("e2"));
            Console.WriteLine(distance2.ToString("e2"));
            Console.WriteLine(distance3.ToString("e2"));
            Console.WriteLine(distance4.ToString("e2"));
        }
    }
}
