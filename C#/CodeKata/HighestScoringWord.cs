using System.Collections.Generic;
using System.Linq;

namespace CodeKata
{
    public class HighestScoringWord
    {
        public static string MySolution(string text)
        {
            List<string> words = new List<string>();
            words = text.Split(null).ToList();

            List<int> numbersOfWords =new List<int>();

            foreach (var word in words)
            {
                int tmp = word.ToLower().Where(char.IsLetter).Select(x => x - 'a' + 1).Sum();
                numbersOfWords.Add(tmp);
            }

            return words[numbersOfWords.IndexOf(numbersOfWords.Max())];
        }

        public static string OtherSolution(string text)
        {
            return text.Split(' ').OrderBy(a => a.Select(b => b - 96).Sum()).Last();
        }
    }
}