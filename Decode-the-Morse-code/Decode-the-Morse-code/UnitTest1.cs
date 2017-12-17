using System;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace Decode_the_Morse_code
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void E()
        {
            var input = ".";
            Assert.AreEqual("E", MorseCodeDecoder.Decode(input));
        }

        [Test]
        public void EH()
        {
            var input = ". ....";
            Assert.AreEqual("EH", MorseCodeDecoder.Decode(input));
        }


        [Test]
        public void HEY_JUDE()
        {
            var input = ".... . -.--   .--- ..- -.. .";
            Assert.AreEqual("HEY JUDE", MorseCodeDecoder.Decode(input));
        }

        [Test]
        public void MorseCodeDecoderBasicTest_6()
        {
            try
            {
                string input = "...---...";
                string expected = "SOS";

                string actual = MorseCodeDecoder.Decode(input);

                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.Fail("There seems to be an error somewhere in your code. Exception message reads as follows: " + ex.Message);
            }
        }

        [Test]
        public void MorseCodeDecoderComplexTest_1()
        {
            try
            {
                string input = " . ";
                string expected = "E";

                string actual = MorseCodeDecoder.Decode(input);

                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.Fail("There seems to be an error somewhere in your code. Exception message reads as follows: " + ex.Message);
            }
        }

        [Test]
        public void MorseCodeDecoderComplexTest_2()
        {
            try
            {
                string input = "   .   . ";
                string expected = "E E";

                string actual = MorseCodeDecoder.Decode(input);

                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.Fail("There seems to be an error somewhere in your code. Exception message reads as follows: " + ex.Message);
            }
        }

        [Test]
        public void MorseCodeDecoderComplexTest_3()
        {
            try
            {
                string input = "      ...---... -.-.--   - .... .   --.- ..- .. -.-. -.-   -... .-. --- .-- -.   ..-. --- -..-   .--- ..- -- .--. ...   --- ...- . .-.   - .... .   .-.. .- --.. -.--   -.. --- --. .-.-.-  ";
                string expected = "SOS! THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG.";

                string actual = MorseCodeDecoder.Decode(input);

                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.Fail("There seems to be an error somewhere in your code. Exception message reads as follows: " + ex.Message);
            }
        }
    }
}
