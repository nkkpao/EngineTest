using EngineTest.Engines;
using EngineTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineTest.Stands
{
    internal class TemperatureTestStand : IStand
    {
        Engine engine;
        double TEnv;
        double timeInterval;
        Func<Engine, bool> testFunc;

        public TemperatureTestStand(Engine engine, double tEnv, double timeInterval)
        {

            this.engine = engine;
            TEnv = tEnv;
            this.timeInterval = timeInterval;
            testFunc = Test;
        }

        public bool Test(Engine engine)
        {
            if(engine.TEngine >= engine.T)
            {
                return true;
            }

            return false;
        }

        public void RunEngineTest()
        {
            engine.Run(TEnv, timeInterval, testFunc);
            Console.WriteLine($"Двигатель перегрелся спустя {engine.runTime} секунд.");
        }
    }
}
