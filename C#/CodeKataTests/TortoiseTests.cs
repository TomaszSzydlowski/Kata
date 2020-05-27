using CodeKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeKataTests
{
    [TestClass]
    public class TortoiseTests
    {
        public delegate int[] Del(int x, int y, int z);
        [TestMethod]
        public void MySolution()
        {
            TortoiseTest(Tortoise.MySolution);
        }

        [TestMethod]
        public void OtherSolution()
        {
            TortoiseTest(Tortoise.OtherSolution);
        }

        private static void TortoiseTest(Del myDel)
        {
            CheckArrays(new[] { 0, 32, 18 }, myDel(720, 850, 70));
            CheckArrays(new[] { 3, 21, 49 }, myDel(80, 91, 37));
            CheckArrays(new[] { 2, 0, 0 }, myDel(80, 100, 40));
        }


        private static void CheckArrays(int[] expected, int[] actual)
        {
            Assert.AreEqual(expected.Length, actual.Length);
            for (var i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

    }
}
