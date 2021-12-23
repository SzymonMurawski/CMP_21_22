using System;

namespace NumericalIntegration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the coefficients of polynomial function");
            string coefficients = Console.ReadLine();
            PolynomialFunction polynomial = new PolynomialFunction(coefficients);
            Console.WriteLine("You've entered the following function:\n" + polynomial.ToString());
            Console.WriteLine("Please enter boundaries for integration: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            TrapezoidalMethod trapezoidalMethod = new TrapezoidalMethod(1000);
            Console.WriteLine("Integral by trapezoidal method: " + trapezoidalMethod.GetIntegral(a, b, polynomial));
            SimpsonsMethod simpsonsMethod = new SimpsonsMethod(1000);
            Console.WriteLine("Integral by trapezoidal method: " + simpsonsMethod.GetIntegral(a, b, polynomial));
        }
    }
}
