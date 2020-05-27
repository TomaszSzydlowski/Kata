//Given the string representations of two integers, return the string representation of the sum of those integers.

using System;
using System.Numerics;

namespace CodeKata
{
    public class SumString
    {
        public static string MySolution(string a, string b)
        {
            string longer = a.Length > b.Length ? a : b;
            string result = String.Empty;
            int moreTen = 0;
            for (int i = 0; i < longer.Length; i++)
            {

                int numberA = i < a.Length ? (short)char.GetNumericValue(a[a.Length - i - 1]) : 0;
                int numberB = i < b.Length ? (short)char.GetNumericValue(b[b.Length - i - 1]) : 0;

                int sum = numberA + numberB + moreTen;
                moreTen = sum > 9 ? 1 : 0;
                result += sum - 10 * moreTen;

            }

            result = moreTen > 0 ? result + moreTen : result;
            char[] charArray = (result).ToCharArray();
            Array.Reverse(charArray);
            result = (charArray[0] == '0' ? new string(charArray).Substring(1) : new string(charArray));

            return result;

        }

        public static string OtherSolution(string a, string b)
        {
            BigInteger aInt;
            BigInteger bInt;

            BigInteger.TryParse(a, out aInt);
            BigInteger.TryParse(b, out bInt);

            return (aInt + bInt).ToString();
        }
    }
}
