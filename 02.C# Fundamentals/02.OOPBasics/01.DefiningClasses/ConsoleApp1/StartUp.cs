using System;


namespace _01.DefineClassPerson
{
    class StartUp
    {
        static void Main()
        {
            var numberOfPeople = int.Parse(Console.ReadLine());
            var family = new Family();

            for (int i = 0; i < numberOfPeople; i++)
            {
                var args = Console.ReadLine().Split();
                var person = new Person(args[0], int.Parse(args[1]));
                family.AddMember(person);
            }
            var oldest = family.GetOldestMember();
            Console.WriteLine($"{oldest.Name} {oldest.Age}");
        }
    }
}
