using System.Collections.Generic;
using System.Linq;
using CodeKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeKataTests
{
    [TestClass]
    public class ElectoralSystemTests
    {
        ElectoralSystem Poland = new ElectoralSystem();

        private Dictionary<string, int> result = new Dictionary<string, int>
        {
            {"PiS", 4},
            {"PO", 3},
            {"Kukiz", 1}
        };

        [TestMethod]
        public void ElectoralSystemTest()
        {
            var actual = Poland.DHondtMethod(new[] {"PiS", "PO", "Kukiz"}, new[] {720, 480, 300}, 8);

            Assert.IsTrue(result.All(e => actual.Contains(e)));
        }
    }
}
