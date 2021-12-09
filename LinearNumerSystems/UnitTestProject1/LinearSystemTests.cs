using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinearNumerSystems;

namespace UnitTestProject1
{
    [TestClass]
    public class LinearSystemTests
    {
        [TestMethod]
        public void TestForwardElimination()
        {
            LinearSystem ls = new LinearSystem(2);
            ls.ForwardElimination();
            
        }
    }
}
