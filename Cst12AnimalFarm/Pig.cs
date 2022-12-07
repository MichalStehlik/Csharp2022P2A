using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cst12AnimalFarm
{
    internal class Pig : Animal, IConsumable, IHerbivore, ICarnivore
    {
        public Pig(double value, string name)
        {
            Energy = value;
            Name = name;
        }

        public double Energy { get; set; }

        public void Consume(Plant smtg)
        {
            if (smtg is IConsumable)
            {
                Energy += (smtg as IConsumable).Energy / 10;
            }
        }

        public void Consume(Animal smtg)
        {
            if (smtg is IConsumable)
            {
                Energy += (smtg as IConsumable).Energy / 5;
            }
        }
        public override string ToString()
        {
            return "Prasátko " + base.ToString();
        }
    }
}
