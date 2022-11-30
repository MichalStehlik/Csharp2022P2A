using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cst09abstraction
{
    internal class AI : IGradeable
    {
        public int Id { get; set; }

        public double Grade { get; private set; }

        public void SetGrade(double value)
        {
            Grade = value;
        }
    }
}
