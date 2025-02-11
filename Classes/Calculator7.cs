using System;

namespace Classes_06_02_25
{
    internal class Calculator7
    {
        public int N { get; set; }


        public Calculator7(double n)
        {
            N = Convert.ToInt32(n);
        }
        public bool CalculateA()
        {
            return N % 2 == 0 && N % 7 == 0 && N % 11 != 0 && N % 13 != 0;
        }
    }
}
