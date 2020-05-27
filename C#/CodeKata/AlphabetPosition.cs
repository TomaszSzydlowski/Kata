using System;
using System.Linq;

namespace CodeKata
{
    public class AlphabetPosition
    {
        public static string MySolution(string text)
        {
            char[] arr = text.ToUpper().ToCharArray();
            string result = String.Empty;

            for (int i = 0; i < arr.Length; i++)
            {
                int n = (int)arr[i] - 64;

                if (n > 0 && n <= 26)
                {
                    result += n.ToString() + " ";
                }
            }

            if (result == String.Empty)
            {
                return result;
            }

            return result.Remove(result.Length - 1);
        }

        public static string OtherSolution(string text)
        {
            return string.Join(" ", text.ToLower().Where(char.IsLetter).Select(x => x - 'a' + 1));
        }
    }
}
