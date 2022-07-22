using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    class Calculation
    {
        public int Add(int a, int b)
        {
            int add;

            add = a + b;

            return add;
        }

        public int Mult(int a, int b)
        {
            int mult;
            mult = a * b;
            return mult;
        }

        public double Divide(int a, int b)
        {
            double result;

            result = a / b;

            return result;
        }
    }
}
