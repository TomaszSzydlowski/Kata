using CodeKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeKataTests
{
    [TestClass]
    public class NextBiggerNumberTests
    {
        public delegate long Del(long n);
        [TestMethod]
        public void MySolution()
        {
            NextBiggerNumberTest(NextBiggerNumber.MySolution);
        }

        [TestMethod]
        public void OtherSolution()
        {
            NextBiggerNumberTest(NextBiggerNumber.OtherSolution);
        }

        private static void NextBiggerNumberTest(Del myDel)
        {
            Assert.AreEqual(1958888208, myDel(1958888082));
            Assert.AreEqual(130122, myDel(123210));
            Assert.AreEqual(1234567908d, myDel(1234567890));
            Assert.AreEqual(208288530, myDel(208288503));
            Assert.AreEqual(21, myDel(12));
            Assert.AreEqual(531, myDel(513));
            Assert.AreEqual(2071, myDel(2017));
            Assert.AreEqual(441, myDel(414));
            Assert.AreEqual(414, myDel(144));
            Assert.AreEqual(-1, myDel(441));
        }
    }
}