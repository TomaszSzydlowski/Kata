using System;

namespace CodeKata
{
    public class Triangle
    {
        public static bool isTriangle(int a, int b, int c)
        {

            int[] t = {a, b, c};
            Array.Sort(t);
            return (t[2] < t[1] + t[0]);
        }

    }
}
