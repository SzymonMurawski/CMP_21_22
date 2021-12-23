using System;

namespace NumericalIntegration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the coefficients of polynomial function or whole expression in infix notation");
            string userInput = Console.ReadLine();
            IFunction function;
            try
            {
                function = new RPNFunction(userInput);
            }
            catch
            {
                function = new PolynomialFunction(userInput);
            }
            Console.WriteLine("You've entered the following function:\n" + function.ToString());
            Console.WriteLine("Please enter boundaries for integration: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            TrapezoidalMethod trapezoidalMethod = new TrapezoidalMethod(1000);
            SimpsonsMethod simpsonsMethod = new SimpsonsMethod(1000);
            
            Console.WriteLine("Integral by trapezoidal method: " + trapezoidalMethod.GetIntegral(a, b, function));
            Console.WriteLine("Integral by Simpsons method: " + simpsonsMethod.GetIntegral(a, b, function));
        }
    }
}
