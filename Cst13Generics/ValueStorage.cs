using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cst13Generics
{
    internal class ValueStorage<T> /*where T : class*/
    {
        public ValueStorage(T value)
        {
            Value = value;
        }

        public T Value { get; private set; }

        public T Increase(T amount)
        {
            Value = amount;
            return Value;
        }

        public T Add<T2>(T2 val) where T2 : T
        {
            Value = (T)val;
            return Value;
        }
    }
}
