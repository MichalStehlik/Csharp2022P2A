using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cst12AnimalFarm
{
    internal interface ICarnivore
    {
        void Consume(Animal smtg);
        public double Energy { get; set; }
    }
}
