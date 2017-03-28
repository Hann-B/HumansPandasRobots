using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumansPandasRobots
{
    abstract class Thoughful
    {
        public string Name { get; set; }

        public void DisplayName()
        {
            Console.WriteLine(this.Name = Name);
        }
        public void DisplayGreeting()
        {
            Console.WriteLine($"Hello, my name is {this.Name}");
        }

        public void DisplayType()
        {
            Console.WriteLine($"I and of the type {GetType().Name}");
        }
    }
}
