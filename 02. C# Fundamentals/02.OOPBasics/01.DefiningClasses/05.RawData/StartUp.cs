using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.RawData
{
    class StartUp
    {
        static void Main()
        {
            var carCount = int.Parse(Console.ReadLine());
            Car[] cars = new Car[carCount];

            for (int i = 0; i < carCount; i++)
            {
                var carArgs = Console.ReadLine().Split();
                var model = carArgs[0];
                var engineSpeed = int.Parse(carArgs[1]);
                var enginePower = int.Parse(carArgs[2]);
                var cargoWeight = int.Parse(carArgs[3]);
                var cargoType = carArgs[4];
                var tire1Pressure = double.Parse(carArgs[5]);
                var tire1Age = int.Parse(carArgs[6]);
                var tire2Pressure = double.Parse(carArgs[7]);
                var tire2Age = int.Parse(carArgs[8]);
                var tire3Pressure = double.Parse(carArgs[9]);
                var tire3Age = int.Parse(carArgs[10]);
                var tire4Pressure = double.Parse(carArgs[11]);
                var tire4Age = int.Parse(carArgs[12]);

                cars[i] = new Car(model, new Engine(engineSpeed, enginePower), new Cargo(cargoWeight, cargoType), new List<Tire> { new Tire(tire1Pressure, tire1Age), new Tire(tire2Pressure, tire2Age), new Tire(tire3Pressure, tire3Age), new Tire(tire4Pressure, tire4Age) });
            }

            var command = Console.ReadLine();

            if (command == "fragile")
            {
                cars.Where(c => c.Cargo.CargoType == "fragile").Where(c => c.Tires.Any(t => t.TirePressure < 1)).Select(c => c.Model).ToList().ForEach(m => Console.WriteLine(m));
            }
            else if(command == "flamable")
            {
                cars.Where(c => c.Cargo.CargoType == "flamable").Where(c => c.Engine.EnginePower > 250).Select(c => c.Model).ToList().ForEach(m => Console.WriteLine(m));
            }
        }
    }
}
