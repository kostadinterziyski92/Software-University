using System;
using System.Collections.Generic;

namespace _06.FilterBase
{
    class StartUp
    {
        static void Main()
        {
            var ageDict = new Dictionary<string, int>();
            var salaryDict = new Dictionary<string, double>();
            var positionDict = new Dictionary<string, string>();

            string line = String.Empty;

            while ((line = Console.ReadLine()) != "filter base")
            {
                var tokens = line.Split();
                var name = tokens[0];
                var ageSuccess = int.TryParse(tokens[tokens.Length - 1], out int age); 
                var salarySuccess = double.TryParse(tokens[tokens.Length - 1], out double salary);

                if (ageSuccess)
                {
                    ageDict[name] = age;
                }
                else if (salarySuccess)
                {
                    salaryDict[name] = salary;
                }
                else
                {
                    var position = tokens[tokens.Length - 1];
                    positionDict[name] = position;
                }
            }

            string cmd = Console.ReadLine();
            switch (cmd)
            {
                case "Age":
                    foreach (var kvp in ageDict)
                    {
                        Console.WriteLine($"Name: {kvp.Key}");
                        Console.WriteLine($"Position: {kvp.Value}");
                        Console.WriteLine(new String('=', 20));
                    }
                    break;
                case "Salary":
                    foreach (var kvp in salaryDict)
                    {
                        Console.WriteLine($"Name: {kvp.Key}");
                        Console.WriteLine($"Salary: {kvp.Value:f2}");
                        Console.WriteLine(new String('=', 20));
                    }
                    break;
                case "Position":
                    foreach (var kvp in positionDict)
                    {
                        Console.WriteLine($"Name: {kvp.Key}");
                        Console.WriteLine($"Position: {kvp.Value}");
                        Console.WriteLine(new String('=', 20));
                    }
                    break;
            }
        }
    }
}
