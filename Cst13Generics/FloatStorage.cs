using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cst13Generics
{
    internal class FloatStorage
    {
        public FloatStorage(float value = 0)
        {
            Value = value;
        }

        public float Value { get; private set; }

        public float Increase(float amount)
        {
            Value += amount;
            return Value;
        }
    }
}
