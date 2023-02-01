using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cst18LINQ
{
    internal class StudentSummary
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public double Avg { get; set; }
        public override string ToString()
        {
            return Name + ": " + Count + "ks " + Avg;
        } 
    }
}
