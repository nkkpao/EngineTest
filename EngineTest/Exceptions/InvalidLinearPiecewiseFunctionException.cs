using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineTest.Exceptions
{
    internal class InvalidLinearPiecewiseFunctionException : Exception
    {
        public InvalidLinearPiecewiseFunctionException()
                : base("Некорректный ввод линейно-кусочной функции")
        { }
    }
}
