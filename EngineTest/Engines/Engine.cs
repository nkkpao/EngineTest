using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineTest.Engines
{
    internal abstract class Engine
    {
        public double I { get; set; } //  Момент инерции двигателя
        public double[] M { get; set; }  // Кусочно-линейная зависимость крутящего момента, вырабатываемого двигателем
        public double[] V { get; set; } // от скорости вращения коленвала
        public double T { get; set; } // Температура перегрева
        public double Hm { get; set; } // Коэффициент зависимости скорости нагрева от крутящего момент
        public double Hv { get; set; } // Коэффициент зависимости скорости нагрева от скорости вращения коленвала
        public double C { get; set; } // Коэффициент зависимости скорости охлаждения от температуры двигателя и окружающей среды
        public double TEngine { get; protected set; } // температура двигателя
        public double runTime { get; protected set; } = 0; //время работы
        public bool testStop = false;

        public double VCurrent { get; protected set; }
        public double MCurrent { get; protected set; }
        public double NCurrent { get; protected set; }

        public virtual void Run(double TEnv, double timeInterval, Func<Engine, bool> test)
        {
        }
    }
}
