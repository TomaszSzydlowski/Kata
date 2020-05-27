using System;
using System.Linq;

namespace CodeKata
{
    public class GetMiddle
    {
        public static string MySolution(string s)
        {
            string[] charArray = s.ToCharArray().Select(c => c.ToString()).ToArray();
            int halfLengthCharArray = s.Length / 2;
            if (s.Length % 2 == 1)
            {
                return charArray[Convert.ToInt32(Decimal.Round(halfLengthCharArray))];
            }

            return charArray[Convert.ToInt32(Decimal.Round(halfLengthCharArray)) - 1] +
                   charArray[Convert.ToInt32(Decimal.Round(halfLengthCharArray))];
        }

        public static string OtherSolution(string s)
        {
            return string.IsNullOrEmpty(s)
                ? s
                : s.Substring((s.Length - 1) / 2, 2 - s.Length % 2);
        }
    }
}
