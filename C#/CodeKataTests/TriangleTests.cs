using CodeKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeKataTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void IsTriangleMySolution()
        {
            Assert.IsTrue(Triangle.isTriangle(10,7,5));
        }
    }
}
