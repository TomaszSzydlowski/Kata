using CodeKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeKataTests
{
    [TestClass]
    public class ArrayDiffTests
    {
        public delegate int[] Del(int[] a, int[] b);

        [TestMethod]
        public void MySolution()
        {
            ArrayDiffTest(ArrayDiff.MySolution);
        }

        [TestMethod]
        public void OtherSolution()
        {
            ArrayDiffTest(ArrayDiff.OtherSolution);
        }

        [TestMethod]
        public void SolutionWithLinq()
        {
            ArrayDiffTest(ArrayDiff.SolutionWithLinq);
        }

        private void ArrayDiffTest(Del myDel)
        {
            CheckArrays(new[] { 2 }, myDel(new[] { 1, 2 }, new[] { 1 }));
            CheckArrays(new[] { 2, 2 }, myDel(new[] { 1, 2, 2 }, new[] { 1 }));
            CheckArrays(new[] { 1 }, myDel(new[] { 1, 2, 2 }, new[] { 2 }));
            CheckArrays(new[] { 1, 2, 2 }, myDel(new[] { 1, 2, 2 }, new int[] { }));
            CheckArrays(new int[] { }, myDel(new int[] { }, new[] { 1, 2 }));
            CheckArrays(new[] { 11, 2, 4 }, myDel(new[] { 5, 8, 11, 2, 4 }, new[] { 8, 5, 99 }));
            CheckArrays(new[] { 11, 2, 4 }, myDel(new[] { 5, 8, 11, 2, 4 }, new[] { 8, 5, 5, 99 }));
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