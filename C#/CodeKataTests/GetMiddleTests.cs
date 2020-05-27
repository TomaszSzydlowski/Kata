using CodeKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeKataTests
{
    [TestClass]
    public class GetMiddleTests
    {
        public delegate string Del(string s);

        [TestMethod]
        public void MySolution()
        {
            GetMiddleTest(GetMiddle.MySolution);
        }

        [TestMethod]
        public void OtherSolution()
        {
            GetMiddleTest(GetMiddle.OtherSolution);
        }

        private static void GetMiddleTest(Del myDel)
        {
            Assert.AreEqual("es", myDel("test"));
            Assert.AreEqual("t", myDel("testing"));
            Assert.AreEqual("dd", myDel("middle"));
            Assert.AreEqual("A", myDel("A"));
        }
    }
}
