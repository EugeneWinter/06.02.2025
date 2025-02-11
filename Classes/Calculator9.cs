using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_06_02_25
{
    internal class Calculator9
    {
        public double K { get; set; }
        public double L { get; set; }
        public double M { get; set; }
        public double N { get; set; }



        public Calculator9(double k, double l, double m, double n)
        {
            K = k;
            L = l;
            M = m;
            N = n;
        }
        public bool CalculateA()
        {
            return K == 0 == L > M && (K < 0 == 2 * L - 3 * N < M);
        }
    }
}
