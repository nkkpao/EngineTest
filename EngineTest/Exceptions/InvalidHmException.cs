﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineTest.Exceptions
{
    internal class InvalidHmException : Exception
    {
        public InvalidHmException() : base("Некорректный ввод коэффициента зависимости скорости нагрева от крутящего момент") { }
    }
}
