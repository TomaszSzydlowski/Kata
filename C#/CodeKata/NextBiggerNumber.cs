//You have to create a function that takes a positive integer number and returns the next bigger number formed by the same digits:

//12 ==> 21
//513 ==> 531
//2017 ==> 2071
//If no bigger number can be composed using those digits, return -1:

//9 ==> -1
//111 ==> -1
//531 ==> -1


using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeKata
{
    public class NextBiggerNumber
    {
        public static long MySolution(long n)
        {
            byte[] numberArray = n.ToString().Select(o => Convert.ToByte(o - 48)).ToArray();

            int firstBigger = -1;

            for (int i = 0; i < numberArray.Length; i++)
            {
                if (numberArray.Length - 2 - i >= 0)
                {
                    if (numberArray[numberArray.Length - 2 - i] < numberArray[numberArray.Length - 1 - i] && firstBigger == -1)
                    {
                        firstBigger = numberArray.Length - 2 - i;
                    }
                }
            }

            if (firstBigger == -1)
            {
                return firstBigger;
            }

            byte[] firstArray = new byte[firstBigger];
            byte[] secondArray = new byte[numberArray.Length - firstBigger];

            for (int i = 0; i < numberArray.Length; i++)
            {
                if (i < firstBigger)
                {
                    firstArray[i] = numberArray[i];
                }
                else
                {
                    secondArray[i - firstBigger] = numberArray[i];
                }
            }

            byte[] secondArraySort = (byte[])secondArray.Clone();

            Array.Sort(secondArraySort);
            List<byte> secondListSort = new List<byte>();

            string finalArray = String.Empty;

            bool isFirst = true;
            for (int i = 0; i < secondArraySort.Length; i++)
            {
                if (secondArray[0] < secondArraySort[i] && isFirst)
                {
                    finalArray += secondArraySort[i].ToString();
                    isFirst = false;
                    secondListSort = secondArraySort.ToList();
                    secondListSort.RemoveAt(i);
                }
            }

            foreach (var element in secondListSort)
            {
                finalArray += element;
            }

            string resultString = String.Empty;

            for (int i = 0; i < firstBigger; i++)
            {
                if (i < firstBigger)
                {
                    resultString += firstArray[i].ToString();
                }


            }
            resultString += finalArray;

            if (Int64.TryParse(resultString, out long result))
            {
                return result;
            }

            return -1;
        }

        public static long OtherSolution(long n)
        {
            String str = GetNumbers(n);
            for (long i = n + 1; i <= long.Parse(str); i++)
            {
                if (GetNumbers(n) == GetNumbers(i))
                {
                    return i;
                }
            }
            return -1;
        }
        public static string GetNumbers(long number)
        {
            return string.Join("", number.ToString().ToCharArray().OrderByDescending(x => x));
        }
    }
}
