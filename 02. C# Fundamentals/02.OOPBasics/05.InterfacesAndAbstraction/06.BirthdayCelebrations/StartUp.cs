using System;
using System.Collections.Generic;

namespace _06.BirthdayCelebrations
{
    class StartUp
    {
        static void Main()
        {
            var infoAndBirthdays = new List<IBiological>();

            GetInfoAndBirthdays(infoAndBirthdays);


            var date = Console.ReadLine();

            GetBirthdayMatch(infoAndBirthdays, date);
        }

        private static void GetInfoAndBirthdays(List<IBiological> infoAndBirhtdays)
        {
            var line = string.Empty;

            while ((line = Console.ReadLine()) != "End")
            {
                var args = line.Split(' ');
                if (args[0] == "Citizen")
                {
                    var name = args[1];
                    var age = int.Parse(args[2]);
                    var id = args[3];
                    var birthdate = args[4];

                    var citizen = new Citizen(name, age, id, birthdate);
                    infoAndBirhtdays.Add(citizen);
                }
                else if(args[0] == "Pet")
                {
                    var name = args[1];
                    var birthdate = args[2];

                    var pet = new Pet(name, birthdate);
                    infoAndBirhtdays.Add(pet);
                }
                
            }
        }

        private static void GetBirthdayMatch(List<IBiological> tokens, string date)
        {
            foreach (var token in tokens)
            {
                if (token.Birthdate.EndsWith(date))
                {
                    Console.WriteLine(token.Birthdate);
                }
            }
        }
    }
}
