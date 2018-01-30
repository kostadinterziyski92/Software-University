using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.TruckTour
{
    class TruckTour
    {
        static void Main()
        {
            var pumpCount = int.Parse(Console.ReadLine());
            var petrolDistance = new Queue<int[]>();

            for (int i = 0; i < pumpCount; i++)
            {
                var pump = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                petrolDistance.Enqueue(pump);
            }

            for (int currentStart = 0; currentStart < pumpCount - 1; currentStart++)
            {
                var fuel = 0;
                bool isSolution = true;

                for (int pumpsPassed = 0; pumpsPassed < pumpCount - 1; pumpsPassed++)
                {
                    var currentPump = petrolDistance.Dequeue();
                    var pumpFuel = currentPump[0];
                    var nextPumpDistance = currentPump[1];

                    petrolDistance.Enqueue(currentPump);

                    fuel += pumpFuel - nextPumpDistance;
                    if (fuel < 0)
                    {
                        currentStart += pumpsPassed;
                        isSolution = false;
                        break;
                    }
                }

                if (isSolution)
                {
                    Console.WriteLine(currentStart);
                    Environment.Exit(0);
                }
            }
        }
    }
}
