﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Decode_the_Morse_code
{
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
            { "--..","Z"},
            { "...---...","SOS"},
            { "-.-.--","!"},
            { ".-.-.-","."},

        };

        public static string Decode(string input)
        {
            var words = SplitToWordFrom(input);
            var result = "";
            foreach (var word in words)
            {
                result = result + DecodWord(word.Trim());
            }
            return result.TrimEnd();
        }

        private static string[] SplitToWordFrom(string input)
        {
            return input.TrimStart().Split(new string[] { "   " }, StringSplitOptions.None);
        }

        private static string DecodWord(string word)
        {
            return word.Split(' ').Aggregate("", (current, code) => current + MorseCode[code]) + " ";
        }
    }
}