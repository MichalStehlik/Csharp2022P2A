using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cst13Generics
{
    internal class IntStorage
    {
        public IntStorage(int value = 0)
        {
            Value = value;
        }

        public int Value { get; private set; }

        public int Increase(int amount)
        {
            Value += amount;
            return Value;
        }
    }
}
