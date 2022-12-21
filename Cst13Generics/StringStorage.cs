using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cst13Generics
{
    internal class StringStorage
    {
        public StringStorage(string value = "")
        {
            Value = value;
        }

        public string Value { get; private set; }

        public string Increase(string addition)
        {
            Value += addition;
            return Value;
        }
    }
}
