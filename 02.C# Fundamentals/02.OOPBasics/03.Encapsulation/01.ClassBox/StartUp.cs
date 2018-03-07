using System;

namespace _01.ClassBox
{
    class StartUp
    {
        static void Main()
        {
            var lenght = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var box = new Box(lenght, width, height);

            Console.WriteLine(box);
        }
    }
}
