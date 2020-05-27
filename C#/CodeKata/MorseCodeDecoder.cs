using System;
using System.Collections.Generic;

namespace CodeKata
{
    public class MorseCodeDecoder
    {
        static Dictionary<string, string> translator = new Dictionary<string, string>
        {
            {".-", "a" },
            {"-...", "b" },
            {"-.-.", "c" },
            {"-..", "d" },
            {".", "e" },
            {"..-.", "f" },
            {"--.", "g" },
            {"....", "h" },
            {"..", "i" },
            {".---", "j" },
            {"-.-", "k" },
            {".-..", "l" },
            {"--", "m"},
            {"-.","n"},
            {"---" ,"o"},
            {".--.", "p" },
            {"--.-", "q" },
            {".-.","r" },
            {"...", "s" },
            {"-", "t" },
            {"..-", "u" },
            {"...-", "v" },
            {".--", "w" },
            {"-..-", "x" },
            {"-.--", "y" },
            {"--..", "z" },
            {"", " " },
            {"...---...", "SOS" },
            {"-.-.--" , "!"},
            {".-.-.-", "."}
    };

        public static string DecodeMySolution(string morseCode)
        {

            var words = morseCode.Split(null);
            string result = String.Empty;

            string lastChar = String.Empty;
            for (int i = 0; i < words.Length; i++)
            {
                if (lastChar != null && lastChar != " " || lastChar != translator[words[i]])
                {
                    result += translator[words[i]];
                    lastChar = translator[words[i]];

                }
            }

            return result.ToUpper().Trim();

        }
    }
}