using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cst09abstraction
{
    internal class Human : Entity
    {
        public string Name { get { return Firstname + " " + Lastname; } }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Id { get; set; }
    }
}
