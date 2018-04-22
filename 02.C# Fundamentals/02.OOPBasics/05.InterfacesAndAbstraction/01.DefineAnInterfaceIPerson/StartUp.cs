using System;

namespace _01.DefineAnInterfaceIPerson
{
    class StartUp
    {
        static void Main()
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string id = Console.ReadLine();
            string bithdate = Console.ReadLine();

            IIdentifiable identifiable = new Citizen(name, age, id, bithdate);
            IBirthable birthable = new Citizen(name, age, id, bithdate);

            Console.WriteLine(identifiable.Id);
            Console.WriteLine(birthable.Birthdate);
        }
    }
}
