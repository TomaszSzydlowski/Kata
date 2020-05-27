using System.Linq;
using System.Text.RegularExpressions;

namespace CodeKata
{
    public class SortStringWithNumber
    {
        public static string MySolutionOrder(string words)
        {

            string[] wordsSplits = words.Split(null);
            string[] drawArray = new string[wordsSplits.Length];

            for (int i = 0; i < wordsSplits.Length; i++)
            {
                if (wordsSplits[i] != "")
                {
                    short numberInWord = short.Parse(Regex.Match(wordsSplits[i], @"\d+").Value);
                    drawArray[numberInWord - 1] = wordsSplits[i];

                    if (numberInWord < wordsSplits.Length)
                    {
                        drawArray[numberInWord - 1] += " ";
                    }
                }
            }

            return string.Join("", drawArray);
        }

        public static string OtherSolutionLinq(string words)
        {
            if (string.IsNullOrEmpty(words)) return words;
            return string.Join(" ", words.Split(' ').OrderBy(s => s.ToList().Find(c => char.IsDigit(c))));
        }
    }
}
