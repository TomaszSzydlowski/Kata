using System.Collections.Generic;

namespace CodeKata
{
    public class DelegateTraining
    {
        private delegate bool TestDel(string s);

        private static string[] items = { "Michal", "Marcin", "Ela" };
        public static string[] result = Where(items, TestForLength);

        static bool TestForLength(string s)
        {
            return s.Length > 3;
        }

        static string[] Where(string[] items, TestDel test)
        {
            var result = new List<string>();
            foreach (var item in items)
            {
                if (test(item))
                {
                    result.Add(item);
                }
            }

            return result.ToArray();
        }
    }
}
