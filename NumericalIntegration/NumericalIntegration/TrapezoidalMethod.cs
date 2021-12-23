using System;
using System.Collections.Generic;
using System.Text;

namespace NumericalIntegration
{
    class TrapezoidalMethod
    {
        public int N;
        public TrapezoidalMethod()
        {
            N = 100;
        }
        public TrapezoidalMethod(int n)
        {
            N = n;
        }
        public double GetIntegral(double a, double b, PolynomialFunction polynomialFunction)
        {
            throw new NotImplementedException();
        }
    }
}
