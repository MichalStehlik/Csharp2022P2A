using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cst11OperatorsStructs
{
    internal class MyNumber
    {
        public MyNumber(int value)
        {
            Value = value;
        }

        public int Value { get; set; }

        public static MyNumber operator + (MyNumber a, int b)
        {
            return new MyNumber(a.Value + b);
        }
        public static MyNumber operator + (MyNumber a, MyNumber b)
        {
            return new MyNumber(a.Value + b.Value);
        }
        public static MyNumber operator +(int a, MyNumber b)
        {
            return new MyNumber(a + b.Value);
        }
    }
}
