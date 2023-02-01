using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cst18LINQ
{
    internal class Student
    {
        public string FirstName { get; set; }
        public string Classroom { get; set; }
        public double AverageGrade { get; set; }
        public override string ToString()
        {
            return FirstName + " " + Classroom + ":" + AverageGrade;
        }
    }
}
