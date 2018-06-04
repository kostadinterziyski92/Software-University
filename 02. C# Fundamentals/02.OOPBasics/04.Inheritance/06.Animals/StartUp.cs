using System;
using System.Collections.Generic;
using System.Data;

namespace _06.Animals
{
    class StartUp
    {
        static void Main()
        {
            var animals = new List<Animal>();

            string line = String.Empty;
            while ((line = Console.ReadLine()) != "Beast!")
            {
                try
                {
                    MakeAnimal(animals, line);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }

        private static void MakeAnimal(List<Animal> animals, string line)
        {
            var type = line;
            var animalArgs = Console.ReadLine().Split();
            var name = animalArgs[0];
            var age = int.Parse(animalArgs[1]);
            string gender = null;
            if (animalArgs.Length == 3)
            {
                gender = animalArgs[2];
            }

            switch (type)
            {
                case "Cat":
                    animals.Add(new Cat(name, age, gender));
                    break;
                case "Dog":
                    animals.Add(new Dog(name, age, gender));
                    break;
                case "Frog":
                    animals.Add(new Frog(name, age, gender));
                    break;
                case "Kitten":
                    animals.Add(new Kitten(name, age));
                    break;
                case "Tomacat":
                    animals.Add(new Tomcat(name, age));
                    break;
                    default:
                    throw new ArgumentException("Invalid input!");
            }
        }
    }
}
