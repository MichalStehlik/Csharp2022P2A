using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cst12AnimalFarm
{
    internal class Cow : Animal, IConsumable, IHerbivore
    {
        public Cow(double value, string name)
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
        public override string ToString()
        {
            return "Kravička " + base.ToString();
        }
    }
}
