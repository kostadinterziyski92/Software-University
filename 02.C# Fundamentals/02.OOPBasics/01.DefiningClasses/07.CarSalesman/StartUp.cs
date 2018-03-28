using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _07.CarSalesman
{
    class StartUp
    {
        static void Main()
        {
            var engineCount = int.Parse(Console.ReadLine());
            Engine[] engines = new Engine[engineCount];

            for (int i = 0; i < engineCount; i++)
            {
                var engineArgs = Console.ReadLine().Split();
                if (engineArgs.Length == 4)
                {
                    var model = engineArgs[0];
                    var power = int.Parse(engineArgs[1]);
                    var displacement = double.Parse(engineArgs[2]);
                    var efficency = engineArgs[3];
                    engines[i] = new Engine(model, power, displacement, efficency);
                }
                else if (engineArgs.Length == 3)
                {
                    double displacement = 0;
                    var tryParse = double.TryParse(engineArgs[2], out displacement);
                    if (tryParse)
                    {
                        var model = engineArgs[0];
                        var power = int.Parse(engineArgs[2]);
                        engines[i] = new Engine(model, power, displacement);
                    }
                    else
                    {
                        var model = engineArgs[0];
                        var power = int.Parse(engineArgs[1]);
                        var efficency = engineArgs[2];
                        engines[i] = new Engine(model, power, efficency);
                    }
                }
                else
                {
                    var model = engineArgs[0];
                    var power = int.Parse(engineArgs[1]);
                }
            }

            var carCount = int.Parse(Console.ReadLine());
            Car[] cars = new Car[carCount];

            for (int i = 0; i < carCount; i++)
            {
                var carArgs = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var model = carArgs[0];
                var engine = carArgs[1];
                int weight = 0;
                var color = "n/a";

                if (carArgs.Length == 3)
                {
                    int parsedWeight;
                    var isItNum = int.TryParse(carArgs[2], out parsedWeight);

                    if (isItNum)
                    {
                         weight = parsedWeight;
                    }
                    else
                    {
                        color = carArgs[2];
                    }
                }
                
                if (carArgs.Length == 4)
                {
                    weight = int.Parse(carArgs[2]);
                    color = carArgs[3];
                }

                Car currentCar = new Car
                {
                    Model = model,
                    Engine = engines.FirstOrDefault(e => e.Model.Equals(engine)),
                    Weight = weight,
                    Color = color
                };

                cars[i] = currentCar;
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car); //ToString() is overriden
            }
        } 
    }
}
