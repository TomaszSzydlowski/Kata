using CodeKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeKataTests
{
    [TestClass]
    public class SortStringWithNumberTests
    {
        public delegate string Del(string text);

        [TestMethod]
        public void MySolution()
        {
            SortStringWithNumberTest(SortStringWithNumber.MySolutionOrder);
        }

        [TestMethod]
        public void OtherSolutionLinq()
        {
            SortStringWithNumberTest(SortStringWithNumber.OtherSolutionLinq);
        }

        private static void SortStringWithNumberTest(Del myDel)
        {
            Assert.AreEqual("Thi1s is2 3a T4est", myDel("is2 Thi1s T4est 3a"));
            Assert.AreEqual("Fo1r the2 g3ood 4of th5e pe6ople", myDel("4of Fo1r pe6ople g3ood th5e the2"));
            Assert.AreEqual("", myDel(""));
        }
    }
}
