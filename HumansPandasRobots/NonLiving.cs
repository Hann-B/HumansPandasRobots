using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumansPandasRobots
{
    abstract class NonLiving : Thoughful
    {
        public bool IsASleep { get; set; }
        public bool TerminatorHere { get; set; } = true;
        
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
            }
            else
            {
                Console.WriteLine("I am not a terminator");
            }

            return TerminatorHere;
        }
    }
}
