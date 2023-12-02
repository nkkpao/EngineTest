using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineTest
{
    internal class EngineProperties
    {
        readonly public double I = 10; //  Момент инерции двигателя
        readonly public double[] M = { 20, 75, 100, 105, 75, 0 };  // Кусочно-линейная зависимость крутящего момента M, вырабатываемого двигателем,
        readonly public double[] V = { 0, 75, 150, 200, 250, 300}; // от скорости вращения коленвала V (соотв.)
        readonly public double T = 110; // Температура перегрева
        readonly public double Hm = 0.01; // Коэффициент зависимости скорости нагрева от крутящего момент
        readonly public double Hv = 0.0001; // Коэффициент зависимости скорости нагрева от скорости вращения коленвала
        readonly public double C = 0.1; // Коэффициент зависимости скорости охлаждения от температуры двигателя и окружающей среды
    }
}
