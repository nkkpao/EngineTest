﻿using EngineTest.Engines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineTest.Interfaces
{
    internal interface IStand
    {
        public void RunEngineTest();
        /// <summary>
        /// Задаёт логику тестирования двигателя.
        /// </summary>
        public bool Test(Engine engine);
    }
}
