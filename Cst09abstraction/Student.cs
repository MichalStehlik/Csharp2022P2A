﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cst09abstraction
{
    internal sealed class Student : Human, IGradeable
    {
        public string Classname { get; set; }
        public double Grade { get; set; }

        public void SetGrade(double value)
        {
            Grade = value;
        }
    }
}
