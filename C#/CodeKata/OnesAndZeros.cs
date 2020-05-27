using System;

namespace CodeKata
{
    public class OnesAndZeros
    {
        public static int MySolution(int[] BinaryArray)
        {
            int sum = 0;

            if (BinaryArray[BinaryArray.Length-1] == 1) sum = 1;
            for (int i = 1; i < BinaryArray.Length; i++)
            {
                int count = 1;
                if (BinaryArray[i - 1] != 0)
                {
                    for (int j = BinaryArray.Length - i; j > 0; j--)
                    {
                        count = count * 2;
                    }

                    sum += count;
                }
            }


            return sum;
        }

        public static int OtherSolution(int[] BinaryArray)
        {
            return Convert.ToInt32(string.Join("", BinaryArray), 2);
        }

    }
}
