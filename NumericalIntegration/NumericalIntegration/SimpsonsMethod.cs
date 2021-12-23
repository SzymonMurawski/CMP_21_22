using System;
using System.Collections.Generic;
using System.Text;

namespace NumericalIntegration
{
    class SimpsonsMethod
    {
        public int N;
        public SimpsonsMethod()
        {
            N = 100;
        }
        public SimpsonsMethod(int n)
        {
            N = n;
        }
        public double GetIntegral(double a, double b, IFunction function)
        {
            throw new NotImplementedException();
        }
    }
}
