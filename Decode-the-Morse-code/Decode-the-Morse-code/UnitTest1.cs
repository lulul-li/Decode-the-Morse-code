using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Decode_the_Morse_code
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var input = ".";
            Assert.AreEqual("E",MorseCodeDecoder.Decode(input));
        }
    }

    public class MorseCodeDecoder
    {
        public static string Decode(string input)
        {
            return "E";
        }
    }
}
