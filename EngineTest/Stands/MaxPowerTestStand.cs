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
        double TEnviroment;
        double timeInterval;
        Func<Engine, bool> testFunc;
        double MaxPower = 0;
        double MaxPowerV = 0;

        public MaxPowerTestStand(Engine engine, double tEnv, double timeInterval)
        {

            this.engine = engine;
            TEnviroment = tEnv;
            this.timeInterval = timeInterval;
            testFunc = Test;
        }

        public void RunEngineTest()
        {
            engine.Run(TEnviroment, timeInterval, testFunc);
            Console.WriteLine($"Максимальная мощность {MaxPower} при {MaxPowerV} рад/сек");
        }

        public bool Test(Engine engine)
        {
            if( engine.NCurrent > MaxPower)
            {
                MaxPower = engine.NCurrent;
                MaxPowerV = engine.VCurrent;
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
