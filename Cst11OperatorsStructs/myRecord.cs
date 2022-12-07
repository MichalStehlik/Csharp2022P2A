using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cst11OperatorsStructs
{
    internal record myRecord
    {
        public myRecord(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }

        public string Firstname { get; init; }
        public string Lastname { get; init; }
    }
}
