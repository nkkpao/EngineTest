using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineTest.Exceptions
{
    internal class InvalidInertiaMomentException : Exception
    {
        public InvalidInertiaMomentException()
            : base("Некорректный ввод момента инерции")
        { }
    }
}
