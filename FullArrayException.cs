using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListExample
{
    public class FullArrayException : Exception
    {
        public FullArrayException(string msg) : base(msg)
        {

        }
    }
}
