using System;
using System.Linq;

namespace _04.SpeedRacing
{
    class StartUp
    {
        static void Main()
        {
            var carCount = int.Parse(Console.ReadLine());
            Car[] cars = new Car[carCount];

            for (int i = 0; i < carCount; i++)
            {
                var carInfo = Console.ReadLine().Split();
                var carModel = carInfo[0];
                var carFuel = decimal.Parse(carInfo[1]);
                var carFConsumption = decimal.Parse(carInfo[2]);
                cars[i] = new Car(carModel, carFuel, carFConsumption);
            }

            var command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                var commandArgs = command.Split();
                var model = commandArgs[1];
                var distance = decimal.Parse(commandArgs[2]);

                cars.Where(c=>c.Model == model).ToList().ForEach(c=>c.Drive(distance));
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
