using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_06_02_25
{
    internal class Calculator15
    {
        public double A { get; set; }
        public double B { get; set; }

        public Calculator15(double a, double b)
        {
            A = Convert.ToInt16(a);
            B = Convert.ToInt16(b);
        }
        public bool CalculateA()
        {
            return (A == 4 || A == 5) && (B == 4 || B == 5);
        }
    }
}
