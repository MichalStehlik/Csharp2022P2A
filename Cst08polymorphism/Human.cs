using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cst08polymorphism
{
    internal class Human
    {
        public string Name { get; set; }
        public virtual string Fullname()
        {
            return Name;
        }

        public override string ToString()
        {
            return Fullname();
        }
    }
}
