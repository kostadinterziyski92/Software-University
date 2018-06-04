using System;
using System.Collections.Generic;

namespace _01.Vehicles
{
    class StartUp
    {
        static void Main()
        {
            try
            {
                var carInfo = Console.ReadLine().Split();
                var carFuel = double.Parse(carInfo[1]);
                var carLitersPerKm = double.Parse(carInfo[2]);
                var carTank = double.Parse(carInfo[3]);
                var car = new Car(carFuel, carLitersPerKm, carTank);

                var truckInfo = Console.ReadLine().Split();
                var truckFuel = double.Parse(truckInfo[1]);
                var truckLitersPerKm = double.Parse(truckInfo[2]);
                var truckTank = double.Parse(truckInfo[3]);
                var truck = new Truck(truckFuel, truckLitersPerKm, truckTank);

                var busInfo = Console.ReadLine().Split();
                var busFuel = double.Parse(busInfo[1]);
                var busLitersPerKm = double.Parse(busInfo[2]);
                var busTank = double.Parse(busInfo[3]);
                var bus = new Bus(busFuel, busLitersPerKm, busTank);

                var commands = int.Parse(Console.ReadLine());

                for (int i = 0; i < commands; i++)
                {
                    var command = Console.ReadLine().Split();
                    var action = command[0];
                    var vehicleType = command[1];
                    var value = double.Parse(command[2]);
                    
                    switch (action)
                    {
                        case "Drive":
                            switch (vehicleType)
                            {
                                case "Car":
                                    car.Drive(value);
                                    break;
                                case "Truck":
                                    truck.Drive(value);
                                    break;
                                case "Bus":
                                    bus.Drive(value);
                                    break;
                            }
                            break;
                        case "Refuel":
                            switch (vehicleType)
                            {
                                case "Car":
                                    car.Refuel(value);
                                    break;
                                case "Truck":
                                    truck.Refuel(value);
                                    break;
                                case "Bus":
                                    bus.Refuel(value);
                                    break;
                            }
                            break;
                        case "DriveEmpty":
                            bus.DriveEmpty(value);
                            break;
                    }
                }

                Console.WriteLine($"Car: {car.Fuel:f2}");
                Console.WriteLine($"Truck: {truck.Fuel:f2}");
                Console.WriteLine($"Bus: {bus.Fuel:f2}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            

            
        }
    }
}
