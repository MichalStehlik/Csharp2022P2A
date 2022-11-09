using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cst06exception
{
    internal class ErrorMaker
    {
        private int _value;

        public ErrorMaker(int value)
        {
            _value = value;
        }

        public int GetValue()
        {
            return _value;
        }

        public bool AddNumber(int number, out int newValue)
        {
            if (number > 0)
            {
                _value += number;
                newValue = _value;
                return true;
            }
            newValue = _value;
            return false;
        }

        public ActionResult AddNumber2(int number)
        {
            if (number > 0)
            {
                _value += number;
                return new ActionResult(_value, true);
            }
            return new ActionResult(_value, false);
        }
        public int AddNumber3(int number)
        {
            if (number == 0)
            {
                throw new StupidUserException("No brain present!");
            }
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException("Hodnota nemůže být záporná");
            }
            _value += number;
            return _value;
        }
    }
}
