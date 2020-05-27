using CodeKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeKataTests
{

    [TestClass]
    public class StringMixTests
    {
        public delegate string Del(string a, string b);

        [TestMethod]
        public void MySolution()
        {
            StringMixTest(StringMix.MySolution);
        }

        [TestMethod]
        public void OtherSolution()
        {
            StringMixTest(StringMix.OtherSolution);
        }

        public void StringMixTest(Del myDel)
        {
            Assert.AreEqual("2:eeeee/2:yy/=:hh/=:rr", myDel("Are they here", "yes, they are here"));
            Assert.AreEqual("1:ooo/1:uuu/2:sss/=:nnn/1:ii/2:aa/2:dd/2:ee/=:gg",myDel("looping is fun but dangerous", "less dangerous than coding"));
            Assert.AreEqual("1:aaa/1:nnn/1:gg/2:ee/2:ff/2:ii/2:oo/2:rr/2:ss/2:tt",myDel(" In many languages", " there's a pair of functions"));
            Assert.AreEqual("1:ee/1:ll/1:oo", myDel("Lords of the Fallen", "gamekult"));
            Assert.AreEqual("", myDel("codewars", "codewars"));
            Assert.AreEqual("1:nnnnn/1:ooooo/1:tttt/1:eee/1:gg/1:ii/1:mm/=:rr",myDel("A generation must confront the looming ", "codewarrs"));
        }
    }
}
