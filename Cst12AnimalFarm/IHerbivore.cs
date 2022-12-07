using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cst12AnimalFarm
{
    internal interface IHerbivore
    {
        void Consume(Plant smtg);
        public double Energy { get; set; }
    }
}
