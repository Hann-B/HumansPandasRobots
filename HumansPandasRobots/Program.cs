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
        List<Thoughful> ListAll = new List<Thoughful>();
            ListAll.Add(new Panda());
            ListAll.Add(new Human());
            ListAll.Add(new Robot());
        List<Living> LivingList = new List<Living>();
            LivingList.Add(new Panda());
            LivingList.Add(new Human());


            Human elliott = new Human()
            {
                Name = "Elliott",
                Food = "Lasagna",
            };
            
            elliott.DisplayName();
            elliott.DisplayGreeting();
            Console.WriteLine(elliott.Eat());
            Console.WriteLine(elliott.GoToSleep());
            Console.WriteLine(elliott.WakeUp());
            elliott.DisplayType();
            Panda ceail = new Panda()
            {
                Name = "Ceail",
                Food = "Bamboo",
            };

            ceail.DisplayName();
            ceail.DisplayGreeting();
            Console.WriteLine(ceail.Eat());
            Console.WriteLine(ceail.GoToSleep());
            Console.WriteLine(ceail.WakeUp());
            ceail.DisplayType();

            Robot titan = new Robot()
            {
                Name = "Titan",
                TerminatorHere = false,
            };

            titan.DisplayName();
            titan.DisplayGreeting();
            Console.WriteLine(titan.StartUp());
            Console.WriteLine(titan.ShutDown());
            Console.WriteLine(titan.IsATerminator());
            ceail.DisplayType();

            Console.WriteLine("");

            

        }
    }
}
