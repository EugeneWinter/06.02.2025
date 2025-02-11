using System;

namespace Classes_06_02_25
{
    internal class Calculator8
    {
        public int N { get; set; }


        public Calculator8(double n)
        {
            N = Convert.ToInt32(n);
        }
        public bool CalculateA()
        {
            return N % 3 != 0 && N % 7 == 0 && N % 10 == 0;
        }
    }
}
