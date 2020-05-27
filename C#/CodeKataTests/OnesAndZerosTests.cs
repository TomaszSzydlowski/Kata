using CodeKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeKataTests
{
    [TestClass]
    public class OnesAndZerosTests
    {

        public delegate int Del(int[] array);

        [TestMethod]
        public void MySolution()
        {
            OnesAndZerosTest(OnesAndZeros.MySolution);
        }

        [TestMethod]
        public void OtherSolution()
        {
            OnesAndZerosTest(OnesAndZeros.OtherSolution);
        }

        private static void OnesAndZerosTest(Del myDel)
        {
            Assert.AreEqual(0, myDel(new[] { 0, 0, 0, 0 }));
            Assert.AreEqual(15, myDel(new[] { 1, 1, 1, 1 }));
            Assert.AreEqual(6, myDel(new[] { 0, 1, 1, 0 }));
            Assert.AreEqual(5, myDel(new[] { 0, 1, 0, 1 }));
        }
    }
}