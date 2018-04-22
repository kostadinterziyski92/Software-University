using System;
using System.Collections.Generic;

namespace _04.BorderControl
{
    class StartUp
    {
        static void Main()
        {
            var borderAdmissions = new List<IIdentifiable>();

            GetBorderApplicants(borderAdmissions);


            var fakeIdNumbers = Console.ReadLine();

            GetInvalidId(borderAdmissions, fakeIdNumbers);
        }

        private static void GetBorderApplicants(List<IIdentifiable> borderAdmissions)
        {
            var line = string.Empty;

            while ((line = Console.ReadLine()) != "End")
            {
                var args = line.Split(' ');
                if (args.Length == 3)
                {
                    var name = args[0];
                    var age = int.Parse(args[1]);
                    var id = args[2];

                    var citizen = new Citizen(name, age, id);
                    borderAdmissions.Add(citizen);
                }
                else
                {
                    var model = args[0];
                    var id = args[1];

                    var robot = new Robot(model, id);
                    borderAdmissions.Add(robot);
                }
            }
        }

        private static void GetInvalidId(List<IIdentifiable> tokens, string fakeIdNumbers)
        {
            foreach (var token in tokens)
            {
                if (token.Id.EndsWith(fakeIdNumbers))
                {
                    Console.WriteLine(token.Id);
                }
            }
        }
    }
}
