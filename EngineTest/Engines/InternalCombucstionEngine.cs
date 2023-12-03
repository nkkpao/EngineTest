﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EngineTest.Engines
{
    internal class InternalCombucstionEngine : Engine
    {
        public InternalCombucstionEngine(EngineProperties engineProperties)
        {
            I = engineProperties.I;
            M = new double[engineProperties.M.Length];
            V = new double[engineProperties.V.Length];
            Array.Copy(engineProperties.M, M, engineProperties.M.Length);
            Array.Copy(engineProperties.V, V, engineProperties.V.Length);
            T = engineProperties.T;
            Hm = engineProperties.Hm;
            Hv = engineProperties.Hv;
            C = engineProperties.C;
            VCurrent = 0;
            MCurrent = M[0];
        }

        public override void Run(double TEnv, double timeInterval, Func<Engine, bool> test)
        {
            double MCurrent = M[0];
            int functionPart = 1;
            TEngine = TEnv;
            if (test.Invoke(this)) { testStop = true; };
            

            while (!testStop)
            {
                
                do
                {
                    double Va = MCurrent / I;
                    double Vh = MCurrent * Hm + Math.Pow(VCurrent, 2) * Hv;
                    double Vc = C * (TEnv - TEngine);
                    TEngine += Vh * timeInterval;
                    TEngine += Vc * timeInterval;
                    
                    
                    runTime += timeInterval;
                    VCurrent += Va * timeInterval;
                    MCurrent = M[functionPart-1] + (M[functionPart] - M[functionPart - 1]) * ((VCurrent - V[functionPart - 1]) / (V[functionPart] - V[functionPart-1]));
                    if (test.Invoke(this))
                    {
                        testStop = true;
                        break;
                    }
                } while (VCurrent <= V[functionPart]);

                if (!((functionPart + 1) >= M.Length))
                {
                    functionPart++;
                }
            }
        }
    }
}
