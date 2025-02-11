using System;

namespace Classes_06_02_25
{
    internal class Calculator2
    {
        public int N { get; set; }


        public Calculator2(double n)
        {
            N = Convert.ToInt32(n);
        }
        public bool CalculateA()
        {
            return N % 4 == 0 || N % 7 == 0;
        }
        public bool CalculateB()
        {
            return N % 5 == 0 || N % 10 != 0;
        }
    }
}
