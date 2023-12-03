using EngineTest.Engines;
using EngineTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineTest.Stands
{
    internal class MaxPowerTestStand : IStand
    {
        Engine engine;
        double TEnv;
        double timeInterval;
        Func<Engine, bool> testFunc;
        double MaxPower = 0;

        public MaxPowerTestStand(Engine engine, double tEnv, double timeInterval)
        {

            this.engine = engine;
            TEnv = tEnv;
            this.timeInterval = timeInterval;
            testFunc = Test;
        }

        public void RunEngineTest()
        {
            engine.Run(TEnv, timeInterval, testFunc);
            Console.WriteLine($"Максимальная мощность {MaxPower}");
        }

        public bool Test(Engine engine)
        {
            if((engine.MCurrent * engine.VCurrent / 1000) > MaxPower)
            {
                MaxPower = (engine.MCurrent * engine.VCurrent / 1000);
                return false;
            }
            else if(engine.VCurrent >= engine.V[engine.V.Length-2])
            {
                return true;
            }
            return false;
        }
    }
}
