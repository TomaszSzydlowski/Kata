using CodeKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeKataTests
{
    [TestClass]
    public class TicTacToeTests
    {
        public delegate int Del(int[,] board);
        [TestMethod]
        public void MySolution()
        {
            TicTacToeTest(TicTacToe.MySolution);
        }

        [TestMethod]
        public void MySolution2()
        {
            TicTacToeTest(TicTacToe.MySolution2);
        }

        private static void TicTacToeTest(Del myDel)
        {
            int[,] board1 = new int[,] { { 1, 1, 1 }, { 0, 2, 2 }, { 0, 0, 0 } };
            Assert.AreEqual(1, myDel(board1));
            int[,] board2 = new int[,] { { 2, 2, 2 }, { 0, 2, 2 }, { 0, 0, 0 } };
            Assert.AreEqual(2, myDel(board2));
            int[,] board3 = new int[,] { { 1, 2, 1 }, { 2, 2, 1 }, { 1, 1, 2 } };
            Assert.AreEqual(0, myDel(board3));
            int[,] board4 = new int[,] { { 2, 2, 0 }, { 0, 2, 2 }, { 0, 0, 0 } };
            Assert.AreEqual(-1, myDel(board4));
        }
    }
}
