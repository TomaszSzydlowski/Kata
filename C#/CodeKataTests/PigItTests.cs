using CodeKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeKataTests
{
    [TestClass]
    public class PigItTests
    {
        public delegate string Del(string s);
        [TestMethod]
        public void MySolution()
        {
            PigItTest(PigIt.MySolution);
        }

        [TestMethod]
        public void MySolutionLinq()
        {
            PigItTest(PigIt.MySolutionLinq);
        }

        private static void PigItTest(Del myDel)
        {
            Assert.AreEqual("igPay atinlay siay oolcay", myDel("Pig latin is cool"));
            Assert.AreEqual("hisTay siay ymay tringsay", myDel("This is my string"));
        }
    }
}
