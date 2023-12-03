using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineTest.Exceptions
{
    internal class InvalidHvException : Exception
    {
        public InvalidHvException(string message) : base(message) { }
    }
}
