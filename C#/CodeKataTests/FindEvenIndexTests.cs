using CodeKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeKataTests
{
    [TestClass]
    public class FindEvenIndexTests
    {
        public delegate int Del(int[] array);

        [TestMethod]
        public void MySolution()
        {
            FindEvenIndexTest(FindEvenIndex.MySolution);
        }

        [TestMethod]
        public void OtherSolution()
        {
            FindEvenIndexTest(FindEvenIndex.FindEvenIndexOtherSolution);
        }


        private static void FindEvenIndexTest(Del myDel)
        {
            Assert.AreEqual(3, myDel(new[] { 1, 2, 3, 4, 3, 2, 1 }));
            Assert.AreEqual(1, myDel(new[] { 1, 100, 50, -51, 1, 1 }));
            Assert.AreEqual(-1, myDel(new[] { 1, 2, 3, 4, 5, 6 }));
            Assert.AreEqual(3, myDel(new[] { 20, 10, 30, 10, 10, 15, 35 }));
        }
    }
}
