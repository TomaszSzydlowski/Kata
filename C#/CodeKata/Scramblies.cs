//Complete the function scramble(str1, str2) that returns true if a portion of str1 characters can be rearranged to match str2, otherwise returns false.

//Notes:

//Only lower case letters will be used(a-z). No punctuation or digits will be included.
//Performance needs to be considered
//Input strings s1 and s2 are null terminated.

using System.Linq;

namespace CodeKata
{
    public class Scramblies
    {

        public static bool MySolution(string str1, string str2)
        {
            byte[] isChar = new byte[str2.Length];
            byte[] neverUse = new byte[str1.Length];
            for (int i = 0; i < str2.Length; i++)
            {
                for (int j = 0; j < str1.Length; j++)
                {
                    if (str2[i] == str1[j] && neverUse[j] != 1)
                    {
                        neverUse[j] = 1;
                        isChar[i] = 1;
                        break;
                    }

                }
                if (isChar[i] == 0)
                    return false;
            }


            return true;
        }


        public static bool MySolution2(string str1, string str2)
        {
            char[] container = str1.OrderBy(x => x).ToArray();
            char[] word = str2.OrderBy(x => x).ToArray();

            byte[] isChar = new byte[word.Length];

            int last = 0;
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = last; j < container.Length && isChar[i] == 0; j++)
                {
                    if (word[i] == container[j])
                    {
                        last = j + 1;
                        isChar[i] = 1;
                    }

                }
                if (isChar[i] == 0)
                    return false;
            }
            return true;
        }

        public static bool OtherSolution(string str1, string str2)
        {
            return str2.All(x => str1.Count(y => y == x) >= str2.Count(y => y == x));
        }

    }
}
