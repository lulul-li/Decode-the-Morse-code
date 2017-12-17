using System;
using System.Collections.Generic;
using System.Linq;
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
    }

    public class MorseCodeDecoder
    {
        private static Dictionary<string, string> MorseCode = new Dictionary<string, string>()
        {
            { ".-","A"},
            { "-...","B"},
            { "-.-.","C"},
            { "-..","D"},
            { ".","E"},
            { "..-.","F"},
            { "--.","G"},
            { "....","H"},
            { "..","I"},
            { ".---","J"},
            { "-.-","K"},
            { ".-..","L"},
            { "--","M"},
            { "-.","N"},
            { "---","O"},
            { ".--.","P"},
            { "--.-","Q"},
            { ".-.","R"},
            { "...","S"},
            { "-","T"},
            { "..-","U"},
            { "...-","V"},
            { ".--","W"},
            { "-..-","X"},
            { "-.--","Y"},
            { "--..","Z"}

        };

        public static string Decode(string input)
        {
            var sentence = input.Split(new string[] { "   " }, StringSplitOptions.None);
            return sentence.Aggregate("", (current, word) => current + DecodSentence(word)).TrimEnd();
        }

        private static string DecodSentence(string word)
        {
            return DecodString(word.Split(' ')) + " ";
        }

        private static string DecodString(string[] input)
        {
            return input.Aggregate("", (current, code) => current + MorseCode[code]);
        }
    }
}
