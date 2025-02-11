using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_06_02_25
{
    internal class Calculator4
    {
        public double N { get; set; }


        public Calculator4(double n)
        {
            N = n;
        }
        public bool CalculateA()
        {
            return N % 3 == 0 && N % 9 != 0 && (N % 4 == 0 == (N % 5 == 0 && N % 24 == 0));
        }
    }
}
