//GOAL
//Write a program that will calculate the number of trailing zeros in a factorial of a given number.
//N! = 1 * 2 * 3 * ... * N
//Be careful 1000! has 2568 digits...

namespace CodeKata
{
    public class TrailingZeros
    {
        public static int MySolution(int n)
        {
            int result = 0;
            int rest = n;
            while (rest / 5 >= 1)
            {
                rest = rest / 5;
                result += rest;
            }

            return result;
        }

        public static int OtherSolution(int n)
        {
            int fives = 0;
            for (int i = 5; i <= n; i *= 5)
                fives += n / i;

            return fives;
        }
    }
}
