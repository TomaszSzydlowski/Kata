namespace CodeKata
{
    public class Tortoise
    {
        public static int[] MySolution(int v1, int v2, int d)
        {
            int V = v2 - v1;
            int t = (d * 3600) / V;
            int h = t / 3600;
            int min = t / 60 - h * 60;
            int s = t - min * 60 - h * 3600;

            return v1 < v2 ? new int[] { h, min, s } : null;
        }

        public static int[] OtherSolution(int v1, int v2, int d)
        {
            if (v1 >= v2)
                return null;
            var ts = System.TimeSpan.FromSeconds((d * 3600) / (v2 - v1));
            return new[] { ts.Hours, ts.Minutes, ts.Seconds };
        }
    }
}
