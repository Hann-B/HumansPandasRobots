using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumansPandasRobots
{
    class Panda
    {
        public string Name { get; set; }
        public string Food { get; set; }
        public bool IsASleep { get; set; }

        public string DisplayName()
        {
            return this.Name = Name;
        }
        public string DisplayGreeting()
        {
            return $"Hello I am a Panda named {this.Name}";
        }

        public string Eat()
        {
            this.Food = Food;
            return $"Yum, I ate {Food}";
        }

        public string GoToSleep()
        {
            if (this.IsASleep)
            {
                return true.ToString();
            }
            return "Going to Sleep";
        }
        public string WakeUp()
        {
            return "Waking Up";
        }

    }
}
