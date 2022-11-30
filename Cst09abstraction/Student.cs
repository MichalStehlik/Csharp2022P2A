using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cst09abstraction
{
    internal sealed class Student : Human
    {
        public string Classname { get; set; }
        public double Grade { get; set; }
    }
}
