using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cst08polymorphism
{
    internal class Teacher : Human
    {
        public string Shortname { get; set; }
        public override string Fullname()
        {
            return "Teacher " + Name + " " + Shortname;
        }
    }
}
