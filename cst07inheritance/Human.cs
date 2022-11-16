using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cst07inheritance
{
    internal class Human
    {
        public Human()
        {
        }

        public Human(string firstname, string lastname, string city)
        {
            Firstname = firstname;
            Lastname = lastname;
            City = city;
        }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string City { get; set; }
        public override string ToString()
        {
            return Firstname + " " + Lastname + " von " + City;
        }
    }
}
