using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cst07inheritance
{
    internal class Student : Human
    {
        public Student() : base()
        {
        }

        public Student(string firstname, string lastname, string classname, string city) 
            : base (firstname, lastname, city)
        {
            Classname = classname;
        }
        public string Classname { get; set; }
    }
}
