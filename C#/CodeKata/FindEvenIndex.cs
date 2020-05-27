using System.Linq;

namespace CodeKata
{
    public class FindEvenIndex
    {
        public static int MySolution(int[] arr)
        {

            for (int i = 1; i <= arr.Length; i++)
            {
                if (arr.Take(i - 1).Sum() == arr.TakeLast(arr.Length - i).Sum()) { return i - 1; }
            }

            return -1;
        }

        public static int FindEvenIndexOtherSolution(int[] arr)
        {
            int leftSum = 0, rightSum = arr.Sum();

            for (int i = 0; i < arr.Length; ++i)
            {
                rightSum -= arr[i];

                if (leftSum == rightSum)
                {
                    return i;
                }

                leftSum += arr[i];
            }

            return -1;
        }
    }
}
