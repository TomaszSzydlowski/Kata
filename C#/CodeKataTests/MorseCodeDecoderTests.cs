using CodeKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeKataTests
{
    [TestClass]
    public class MorseCodeDecoderTests
    {
        [TestMethod]
        public void MySolution()
        {
            Assert.AreEqual("HEY JUDE", MorseCodeDecoder.DecodeMySolution(".... . -.--   .--- ..- -.. ."));
            Assert.AreEqual("SOS", MorseCodeDecoder.DecodeMySolution("...---..."));
        }
    }
}
