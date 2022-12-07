using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cst12AnimalFarm
{
    internal class Grass : Plant, IConsumable
    {
        public Grass(double value)
        {
            Energy = value;
        }

        public double Energy { get; private set; }

        public override string ToString()
        {
            return "Tráva";
        }
    }
}
