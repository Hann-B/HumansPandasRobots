using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumansPandasRobots
{
    class Program
    {
        static void Main(string[] args)
        {

            Human elliott = new Human()
            {
                Name = "Elliott",
                Food = "Lasagna",
            };

            Console.WriteLine(elliott.Name);
            Console.WriteLine(elliott.DisplayGreeting());
            Console.WriteLine(elliott.Eat());
            Console.WriteLine(elliott.GoToSleep());
            Console.WriteLine(elliott.WakeUp());

            Panda ceail = new Panda()
            {
                Name = "Ceail",
                Food = "Bamboo",
            };

            Console.WriteLine(ceail.Name);
            Console.WriteLine(ceail.DisplayGreeting());
            Console.WriteLine(ceail.Eat());
            Console.WriteLine(ceail.GoToSleep());
            Console.WriteLine(ceail.WakeUp());

            Robot titan = new Robot()
            {
                Name = "Titan",
                TerminatorHere = false,
            };

            Console.WriteLine(titan.Name);
            Console.WriteLine(titan.DisplayGreeting());
            Console.WriteLine(titan.StartUp());
            Console.WriteLine(titan.ShutDown());
            Console.WriteLine(titan.IsATerminator());


        }
    }
}
