using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cst08polymorphism
{
    internal class Student : Human
    {
        public int Grade { get; set; }
        public override string Fullname()
        {
            return "Student " + Name + " " + Grade;
        }
    }
}
