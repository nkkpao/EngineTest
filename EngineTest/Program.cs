using EngineTest.Builders;
using EngineTest.Engines;
using EngineTest.Stands;
using System;

namespace EngineTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите температуру в помещении");
            double TEnv = Convert.ToDouble(Console.ReadLine());
            double timeInterval = 0.1;

            EngineBuilder builder = new EngineBuilder();
            EngineProperties properties = new EngineProperties();
            Engine engine = builder.BuildICEngine(properties);
            TemperatureTestStand standOne = new TemperatureTestStand(engine, TEnv, timeInterval);

            standOne.RunEngineTest();


        }
    }
}
