using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.FoodShortage
{
    class StartUp
    {
        static void Main()
        {
            var people = new List<IBuyer>();
            var numberofPeople = int.Parse(Console.ReadLine());

            GetCitizensAndRebels(numberofPeople, people);

            var line = string.Empty;
            while ((line = Console.ReadLine()) != "End")
            {
                foreach (var buyer in people.Where(b => b.Name == line))
                {
                    buyer.BuyFood();
                }
            }

            var totalFood = people.Sum(p => p.Food);
            Console.WriteLine(totalFood);
        }

        private static void GetCitizensAndRebels(int numberofPeople, List<IBuyer> people)
        {
            for (int i = 0; i < numberofPeople; i++)
            {
                var personArgs = Console.ReadLine().Split(' ');
                switch (personArgs.Length)
                {
                    case 4:
                        var name = personArgs[0];
                        var age = int.Parse(personArgs[1]);
                        var id = personArgs[2];
                        var birthdate = personArgs[3];
                        var citizen = new Citizen(name, age, id, birthdate);

                        people.Add(citizen);

                        break;

                    case 3:
                        var rebelName = personArgs[0];
                        var rebelAge = int.Parse(personArgs[1]);
                        var group = personArgs[2];
                        var rebel = new Rebel(rebelName, rebelAge, @group);

                        people.Add(rebel);

                        break;
                }
            }
        }
    }
}
