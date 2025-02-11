using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_06_02_25
{
    internal class Calculator11
    {
        public double A { get; set; }
        public double B { get; set; }


        public Calculator11(double a)
        {
            A = a;
            if (A >= 4000 && A < 6000)
                B = 0.95;
            else if (A >= 6000 && A <= 10000)
                B = 0.9 ;
            else if (A > 0 && A < 4000)
                B = 0.9;
            else B = 0;
        }
        public double CalculateA()
        {
            return A * B;
        }
    }
}
