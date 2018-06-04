using System;
using System.Text;

namespace _02.FerrariTask
{
    class StartUp
    {
        static void Main()
        {
            var driver = Console.ReadLine();

            Ferrari ferrari = new Ferrari("488-Spider", driver);

            Console.Write(ferrari.Model + "/");
            Console.Write(ferrari.PushBrakes() + "/");
            Console.Write(ferrari.PushGas() + "/");
            Console.Write(ferrari.Driver); 
        }
    }
}
