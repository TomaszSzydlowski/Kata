using CodeKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeKataTests
{
    [TestClass]
    public class RowSumOddNumbersTests
    {

        public delegate long Del(long n);
        [TestMethod]
        public void MySolution()
        {
            RowSumOddNumberTest(RowSumOddNumbers.MySolution);
        }

        [TestMethod]
        public void OtherSolution()
        {
            RowSumOddNumberTest(RowSumOddNumbers.OtherSolution);
        }

        private static void RowSumOddNumberTest(Del myDel)
        {
            Assert.AreEqual(1, myDel(1));
            Assert.AreEqual(27, myDel(3));
        }
    }
}
