using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeWord.OOPFunciton.FException
{
    class ExceptionSqrtSize : Exception
    {
        public ExceptionSqrtSize(string message)
            : base(message)
        { }
    }
}
