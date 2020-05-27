using CodeKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeKataTests
{
    [TestClass]
    public class HighestScoringWordTests
    {
        public delegate string Del(string s);

        [TestMethod]
        public void MySolution()
        {
            HighestScoringWordTest(HighestScoringWord.MySolution);
        }

        [TestMethod]
        public void OtherSolution()
        {
            HighestScoringWordTest(HighestScoringWord.OtherSolution);
        }

        private static void HighestScoringWordTest(Del myDel)
        {
            Assert.AreEqual("taxi", myDel("man i need a taxi up to ubud"));
            Assert.AreEqual("volcano", myDel("what time are we climbing up to the volcano"));
            Assert.AreEqual("semynak", myDel("take me to semynak"));
        }

    }
}