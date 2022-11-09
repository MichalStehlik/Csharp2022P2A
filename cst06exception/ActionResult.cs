using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cst06exception
{
    internal class ActionResult
    {
        public ActionResult(int value, bool success)
        {
            Value = value;
            Success = success;
        }

        public int Value { get; set; }
        public bool Success { get; set; }
    }
}
