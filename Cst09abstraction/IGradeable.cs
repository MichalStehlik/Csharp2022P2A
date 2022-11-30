using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cst09abstraction
{
    internal interface IGradeable
    {
        void SetGrade(double value);
        double Grade { get; }
    }
}
