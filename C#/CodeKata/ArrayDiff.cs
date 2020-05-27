using System.Collections.Generic;
using System.Linq;

namespace CodeKata
{
    public class ArrayDiff
    {
        public static int[] MySolution(int[] a, int[] b)
        {
            int[] numbers = a;
            int howManyRemove = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j])
                    {
                        List<int> tmp = new List<int>(numbers);
                        tmp.RemoveAt(i - howManyRemove);
                        howManyRemove++;
                        numbers = tmp.ToArray();
                        break;
                    }
                }
            }

            return numbers;
        }
        public static int[] OtherSolution(int[] a, int[] b)
        {
            int[] result = new int[a.Length];
            int resultIndex = 0;
            for (int i = 0; i < a.Length; i++)
                if (!IsPresent(a[i], b))
                {
                    result[resultIndex] = a[i];
                    resultIndex++;
                }
            int[] answer = new int[resultIndex];
            for (int i = 0; i < resultIndex; i++)
                answer[i] = result[i];
            return answer;
        }
        public static bool IsPresent(int num, int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                if (num == arr[i]) return true;
            return false;
        }

        public static int[] SolutionWithLinq(int[] a, int[] b)
        {
            return a.Where(n => !b.Contains(n)).ToArray();
        }
    }
}

