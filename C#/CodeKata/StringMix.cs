#region Instructions


/*Given two strings s1 and s2, we want to visualize how different the two strings are.We will only take into account the lowercase letters(a to z). First let us count the frequency of each lowercase letters in s1 and s2.

s1 = "A aaaa bb c"

s2 = "& aaa bbb c d"

s1 has 4 'a', 2 'b', 1 'c'

s2 has 3 'a', 3 'b', 1 'c', 1 'd'

So the maximum for 'a' in s1 and s2 is 4 from s1; the maximum for 'b' is 3 from s2.In the following we will not consider letters when the maximum of their occurrences is less than or equal to 1.

We can resume the differences between s1 and s2 in the following string: "1:aaaa/2:bbb" where 1 in 1:aaaa stands for string s1 and aaaa because the maximum for a is 4. In the same manner 2:bbb stands for string s2 and bbb because the maximum for b is 3.

The task is to produce a string in which each lowercase letters of s1 or s2 appears as many times as its maximum if this maximum is strictly greater than 1; these letters will be prefixed by the number of the string where they appear with their maximum value and :. If the maximum is in s1 as well as in s2 the prefix is =:.

In the result, substrings(a substring is for example 2:nnnnn or 1:hhh; it contains the prefix) will be in decreasing order of their length and when they have the same length sorted in ascending lexicographic order(letters and digits - more precisely sorted by codepoint); the different groups will be separated by '/'. See examples and "Example Tests".

Hopefully other examples can make this clearer.

s1 = "my&friend&Paul has heavy hats! &"
s2 = "my friend John has many many friends &"
mix(s1, s2) --> "2:nnnnn/1:aaaa/1:hhh/2:mmm/2:yyy/2:dd/2:ff/2:ii/2:rr/=:ee/=:ss"

s1 = "mmmmm m nnnnn y&friend&Paul has heavy hats! &"
s2 = "my frie n d Joh n has ma n y ma n y frie n ds n&"
mix(s1, s2) --> "1:mmmmmm/=:nnnnnn/1:aaaa/1:hhh/2:yyy/2:dd/2:ff/2:ii/2:rr/=:ee/=:ss"

s1= "Are the kids at home? aaaaa fffff"
s2= "Yes they are here! aaaaa fffff"
mix(s1, s2) --> "=:aaaaaa/2:eeeee/=:fffff/1:tt/2:rr/=:hh"
Note for Swift, R, PowerShell
The prefix =: is replaced by E:

s1 = "mmmmm m nnnnn y&friend&Paul has heavy hats! &"
s2 = "my frie n d Joh n has ma n y ma n y frie n ds n&"
mix(s1, s2) --> "1:mmmmmm/E:nnnnnn/1:aaaa/1:hhh/2:yyy/2:dd/2:ff/2:ii/2:rr/E:ee/E:ss"*/

#endregion

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeKata
{
    public class StringMix
    {
        public static string MySolution(string a, string b)
        {
            List<string> result = new List<string>();
            int[,] dataA = GetAnalyzedString(a);
            int[,] dataB = GetAnalyzedString(b);

            int maxIndex = MaxIndex(dataA, dataB);

            while (maxIndex > -1)
            {
                if (dataA[maxIndex, 0] > dataB[maxIndex, 0])
                {
                    result.Add(SetOnePiece('1', dataA, maxIndex));
                }

                if (dataA[maxIndex, 0] < dataB[maxIndex, 0])
                {
                    result.Add(SetOnePiece('2', dataB, maxIndex));
                }
                if (dataA[maxIndex, 0] == dataB[maxIndex, 0])
                {
                    result.Add(SetOnePiece('3', dataA, maxIndex));
                }

                SetRepeated(dataA, maxIndex);
                SetRepeated(dataB, maxIndex);

                maxIndex = MaxIndex(dataA, dataB);
            }

            var newList = result.OrderByDescending(n => n.Length).ThenBy(r => r);
            string newString = String.Join("/", newList.OrderByDescending(x => x.Length).ToArray());

            string finalResult = newString.Replace('3', '=');
            return finalResult;
        }   

        private static int[,] GetAnalyzedString(string a)
        {
            int[,] data = new int[26, 2];
            for (int i = 0; i < a.Length; i++)
            {
                if (Char.IsLetter(a[i]) && a[i]>=97)
                {
                    data[a[i] - 97, 0]++;
                }
            }

            return data;
        }

        public static int MaxIndex(int[,] dataA, int[,] dataB)
        {
            int maxValue = Int32.MinValue;
            int maxValueIndex = Int32.MinValue;

            for (int i = 0; i < 26; i++)
            {
                if (maxValue < dataA[i, 0] && dataA[i, 1] == 0)
                {
                    maxValue = dataA[i, 0];
                    maxValueIndex = i;
                }
                if (maxValue < dataB[i, 0] && dataB[i, 1] == 0)
                {
                    maxValue = dataB[i, 0];
                    maxValueIndex = i;
                }
            }

            if (maxValue < 2)
            {
                return -1;
            }
            return maxValueIndex;
        }

        public static void SetRepeated(int[,] data, int index)
        {
            data[index, 1] = 1;
        }

        public static string SetOnePiece(char sign, int[,] data, int maxIndex)
        {
            string temp = String.Empty;
            temp += sign + ":";
            for (int i = 0; i < data[maxIndex, 0]; i++)
            {
                temp += Char.ConvertFromUtf32(maxIndex + 97);
            }

            return temp;
        }

        public static string OtherSolution(string s1, string s2)
        {
            var s1Group = s1.Where(c => char.IsLower(c) && char.IsLetter(c)).GroupBy(a => a, b => b).Select(a => new { letter = a.Key, count = a.Count() });

            var s2Group = s2.Where(c => char.IsLower(c) && char.IsLetter(c)).GroupBy(a => a, b => b).Select(a => new { letter = a.Key, count = a.Count() });

            var s12Group = s1Group.Concat(s2Group).GroupBy(a => a.letter, b => b);

            var sGrouped = s12Group.Select(a => new {
                count = a.OrderByDescending((p => p.count)).First().count,
                letter = a.Key,
                winner = s1.Count(i => i == a.Key) > s2.Count(i => i == a.Key)
                    ? "1" : s1.Count(i => i == a.Key) < s2.Count(i => i == a.Key) ? "2" : "="
            });

            return string.Join("/", sGrouped.Where(o => o.count > 1).OrderByDescending(o => o.count)
                .ThenBy(o => int.Parse(o.winner == "=" ? "3" : o.winner))
                .ThenBy(o => o.letter).Select(gz => gz.winner + ":" + new string(gz.letter, gz.count)));
        }
    }
}
