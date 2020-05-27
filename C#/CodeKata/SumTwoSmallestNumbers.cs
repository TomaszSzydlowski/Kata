using System;
using System.Linq;

namespace CodeKata
{
    public class SumTwoSmallestNumbers
    {
        public int ExampleOne(int[] numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentNullException("numbers");
            }

            if (numbers.Length < 2)
            {
                throw new ArgumentException("numbers", "The array must have at least two elements.");
            }

            var x = int.MaxValue;
            var y = int.MaxValue;

            foreach (var z in numbers)
            {
                if (z < x)
                {
                    y = x;
                    x = z;
                }
                else if (z < y)
                {
                    y = z;
                }
            }

            return x + y;
        }

        public int ExampleTwo(int[] numbers)
        {
            return numbers.OrderBy(i => i).Take(2).Sum();
        }
    }
}
