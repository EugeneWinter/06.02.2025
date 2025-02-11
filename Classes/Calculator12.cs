using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_06_02_25
{
    internal class Calculator12
    {
        public double K { get; set; }
        public double L { get; set; }
        public double M { get; set; }
        public double N { get; set; }



        public Calculator12(double k, double l, double m, double n)
        {
            K = k;
            L = l;
            M = m;
            N = n;
        }
        public bool CalculateA()
        {
            return (K + L + M + N) > 0 && (K > 0 == (2 * M > L)) && (K < 0 == N > 3 * L);
        }
    }
}
