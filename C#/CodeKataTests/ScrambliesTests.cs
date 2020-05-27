    using CodeKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeKataTests
{
    [TestClass]
    public class ScrambliesTests
    {
        public delegate bool Del(string str1, string str2);

        [TestMethod]
        public void MySolution()
        {
           ScrambliesTest(Scramblies.MySolution);
        }

        [TestMethod]
        public void MySolution2()
        {
            ScrambliesTest(Scramblies.MySolution2);
        }

        [TestMethod]
        public void OtherSolution()
        {
            ScrambliesTest(Scramblies.OtherSolution);
        }

        public void ScrambliesTest(Del MyDel)
        {
            Assert.AreEqual(MyDel("rkqodlw", "world"), true);
            Assert.AreEqual(MyDel("cedewaraaossoqqyt", "codewars"), true);
            Assert.AreEqual(MyDel("katas", "steak"), false);
            Assert.AreEqual(MyDel("scriptjavx", "javascript"), false);
            Assert.AreEqual(MyDel("scriptingjava", "javascript"), true);
            Assert.AreEqual(MyDel("scriptsjava", "javascripts"), true);
            Assert.AreEqual(MyDel("javscripts", "javascript"), false);
            Assert.AreEqual(MyDel("aabbcamaomsccdd", "commas"), true);
            Assert.AreEqual(MyDel("commas", "commas"), true);
            Assert.AreEqual(MyDel("sammoc", "commas"), true);
        }
    }
}
