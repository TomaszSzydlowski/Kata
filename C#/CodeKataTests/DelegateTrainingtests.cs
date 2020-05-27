using CodeKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace CodeKataTests
{
    [TestClass]
    public class DelegateTrainingTests
    {
        [TestMethod]
        public void Test1IsTrue()
        {
            string[] expected = new[] { "Michal", "Marcin" };
            string[] actual = DelegateTraining.result;

            Assert.IsTrue(expected.All(e => actual.Contains(e)));
        }
        [TestMethod]
        public void Test1IsFalse()
        {
            string[] expected = new[] { "Michal", "Marcin", "Ela" };
            string[] actual = DelegateTraining.result;

            Assert.IsFalse(expected.All(e => actual.Contains(e)));
        }
    }
}
