using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumericalIntegration;

namespace PolynomialFunctionTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestToStringSingleCoefficient()
        {
            PolynomialFunction polynomial = new PolynomialFunction("5");
            Assert.AreEqual("f(x) = 5", polynomial.ToString());
            Assert.AreEqual(5, polynomial.GetValueAtX(1));
        }
        [TestMethod]
        public void TestToStringTwoCoefficients()
        {
            PolynomialFunction polynomial = new PolynomialFunction("3 5");
            Assert.AreEqual("f(x) = 3x + 5", polynomial.ToString());
            Assert.AreEqual(8, polynomial.GetValueAtX(1));
        }
        [TestMethod]
        public void TestToStringNegativeCoefficient()
        {
            PolynomialFunction polynomial = new PolynomialFunction("3 -7 5");
            Assert.AreEqual("f(x) = 3x^2 -7x + 5", polynomial.ToString());
            Assert.AreEqual(1, polynomial.GetValueAtX(1));
        }
        [TestMethod]
        public void TestToStringMultipleCoefficients()
        {
            PolynomialFunction polynomial = new PolynomialFunction("1 2 3 -4");
            Assert.AreEqual("f(x) = 1x^3 + 2x^2 + 3x -4", polynomial.ToString());
            Assert.AreEqual(2, polynomial.GetValueAtX(1));
        }
    }
}
