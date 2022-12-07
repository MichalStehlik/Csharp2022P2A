using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cst11OperatorsStructs
{
    internal struct DataStruct
    {
        public DataStruct(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string GetName()
        {
            return Firstname + " " + Lastname;
        }
    }
}
