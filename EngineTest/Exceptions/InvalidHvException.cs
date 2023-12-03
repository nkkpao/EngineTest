using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineTest.Exceptions
{
    internal class InvalidHvException : Exception
    {
        public InvalidHvException() : base("Некорректный ввод коэффициента зависимости скорости нагрева от скорости вращения коленвала") { }
    }
}
