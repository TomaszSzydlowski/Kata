using CodeKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeKataTests
{
    [TestClass]
    public class SumStringTests
    {
        public delegate string Del(string a, string b);

        [TestMethod]
        public void MySolution()
        {
            SumStringTest(SumString.MySolution);
        }

        [TestMethod]
        public void OtherSolution()
        {
            SumStringTest(SumString.OtherSolution);
        }

        private static void SumStringTest(Del myDel)
        {
            Assert.AreEqual("579", myDel("123", "456"));
            Assert.AreEqual("33333333333333333333333333333333333", myDel("11111111111111111111111111111111111", "22222222222222222222222222222222222"));
            Assert.AreEqual("123", myDel("1", "122"));
            Assert.AreEqual("123", myDel("122", "1"));
            Assert.AreEqual("123", myDel("0122", "01"));
            Assert.AreEqual("197530", myDel("98765", "98765"));
        }
    }
}
