using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinearNumerSystems;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddEquation()
        {
            LinearSystem ls = new LinearSystem(2);
            ls.AddEquation("2 3 4", 0);
            Assert.AreEqual(ls.AugmentedMatrix[0, 0], 2);
        }
    }
}
