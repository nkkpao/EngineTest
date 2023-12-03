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
            double timeInterval = 0.01; //как часто будет производиться просчёт показателей двигателя, влияет на точность

            EngineBuilder builder = new EngineBuilder();
            EngineProperties properties = new EngineProperties();
            Engine engine = builder.BuildICEngine(properties);
            Engine engine1 = builder.BuildICEngine(properties);
            TemperatureTestStand standOne = new TemperatureTestStand(engine, TEnv, timeInterval);
            MaxPowerTestStand standTwo = new MaxPowerTestStand(engine1, TEnv, timeInterval);

            standOne.RunEngineTest();
            standTwo.RunEngineTest();

            Console.WriteLine("Все тесты окончены.");
            Console.WriteLine("Для закрытия нажмите любую клавишу...");
            Console.ReadKey();

        }
    }
}
