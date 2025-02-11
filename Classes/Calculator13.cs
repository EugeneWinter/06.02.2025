using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_06_02_25
{
    internal class Calculator13
    {
        public double T { get; set; }
        public double DT { get; set; }
        public double S { get; set; }
        public double D { get; set; }

        public Calculator13(double t, double dt, double s, int d)
        {
            T = t;
            DT = dt;
            S = s;
            D = d;
        }

        public double CalculateA()
        {
            if (S >= 22 || S < 8)
            {
                S *= 0.8;
            }
            if (D == 6 || D == 7)
            {
                S *= 0.9;
            }
            return S * DT;
        }
    }
}
