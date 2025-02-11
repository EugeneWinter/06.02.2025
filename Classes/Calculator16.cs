using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_06_02_25
{
    internal class Calculator16
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double D { get; set; }

        public Calculator16(double a, double b, double c, double d)
        {
            A = a; 
            B = b; 
            C = c; 
            D = d;
        }
        public bool CalculateA()
        {
            int counter = 0;
            List<double> nums = new List<double>() { A, B, C, D };
            foreach (double i in nums)
            {
                if (i % 2 == 0)
                    counter++;
            }
            return counter == 2;
        }
        public void DisplayResults16()
        {
            bool ResultA = CalculateA();

            Console.WriteLine($"A = {ResultA}");
            Console.ReadLine();
        }
    }
}
