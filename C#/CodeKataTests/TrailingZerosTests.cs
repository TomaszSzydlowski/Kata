using CodeKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeKataTests
{
    [TestClass]
    public class TrailingZerosTests
    {
        public delegate int Del(int x);

        [TestMethod]
        public void MySolution()
        {
            TrailingZerosTest(TrailingZeros.MySolution);
        }

        [TestMethod]
        public void OtherSolution()
        {
            TrailingZerosTest(TrailingZeros.OtherSolution);
        }

        private static void TrailingZerosTest(Del myDel)
        {
            Assert.AreEqual(1, myDel(5));
            Assert.AreEqual(6, myDel(25));
            Assert.AreEqual(131, myDel(531));
        }
    }
}
