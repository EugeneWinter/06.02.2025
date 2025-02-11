using System;

namespace Classes_06_02_25
{
    internal class Calculator10
    {
        public int N { get; set; }


        public Calculator10(double n)
        {
            N = Convert.ToInt32(n);
        }
        public bool CalculateA()
        {
            return N % 2 == 0 && (N % 3 != 0 == (N % 7 == 0)) && (N % 5 != 0 == (N % 4 != 0)) && (N % 8 == 0 == (N % 11 == 0));
        }
    }
}
