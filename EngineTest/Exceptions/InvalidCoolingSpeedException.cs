using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineTest.Exceptions
{
    internal class InvalidCoolingSpeedException : Exception
    {
        public double Value { get; }
        public InvalidCoolingSpeedException()
            : base("Некорректный ввод коэффициента скорости охлаждения")
        {
        }
    }
}
