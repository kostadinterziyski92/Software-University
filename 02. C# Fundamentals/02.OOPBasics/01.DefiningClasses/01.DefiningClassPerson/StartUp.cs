using System;
using System.Linq;


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

            var olderThanThirty = family.people.Where(p => p.Age > 30).OrderBy(p => p.Name);
            foreach (var person in olderThanThirty)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
