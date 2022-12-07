using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cst12AnimalFarm
{
    internal class Tiger : Animal, ICarnivore
    {
        public Tiger(double value, string name)
        {
            Energy = value;
            Name = name;
        }

        public double Energy { get; set; }
        

        public void Consume(Animal smtg)
        {
            if (smtg is IConsumable)
            {
                Energy += (smtg as IConsumable).Energy / 5;
            }
        }

        public override string ToString()
        {
            return "Tygr " + base.ToString();
        }
    }
}
