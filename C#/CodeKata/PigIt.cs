//Move the first letter of each word to the end of it, then add "ay" to the end of the word. Leave punctuation marks untouched.

using System;
using System.Linq;

namespace CodeKata
{
    public class PigIt
    {
        public static string MySolution(string str)
        {
            string[] words = str.Split(' ');
            string result = String.Empty;
            foreach (var word in words)
            {
                result += (word + word[0] + "ay").Substring(1) + " ";
            }

            return result.Trim();
        }

        public static string MySolutionLinq(string str)
        {
            return string.Join(" ", str.Split(' ').Select(w => w.Substring(1) + w[0] + "ay"));
        }
    }
}
