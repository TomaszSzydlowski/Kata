namespace CodeKata
{
    public class RowSumOddNumbers
    {
        public static long MySolution(long n)
        {
            long result = 0;

            long count = 0;

            for (long i = n; i > 0; i--)
            {
                count += i;
            }

            long[] lista = new long[count];


            for (long i = 0; i < count; i++)
            {
                lista[i] = 2 * i + 1;
            }

            for (long i = n; i > 0; i--)
            {
                result += lista[count - i];
            }

            return result;
        }

        public static long OtherSolution(long n)
        {
            return n * n * n;
        }
    }
}
