using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumansPandasRobots
{
    class Robot
    {
        public string Name { get; set; }
        public bool IsASleep { get; set; }
        public bool TerminatorHere { get; set; } = true;

        public string DisplayName()
        {
            return this.Name = Name;
        }
        public string DisplayGreeting()
        {
            return $"Hello I am a Robot named {this.Name}";
        }

        public string StartUp()
        {
            return "Started...";
        }
        public string ShutDown()
        {
            if (this.IsASleep)
            {
                return true.ToString();
            }
            return "Shutdown...";
        }

        public bool IsATerminator()
        {
            if (TerminatorHere)
            {
                Console.WriteLine("I am the terminator");
            }else
            {
                Console.WriteLine("I am not a terminator");
            }

            return TerminatorHere;
        }
    }
}
