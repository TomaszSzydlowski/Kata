using System.Collections.Generic;
using System.Linq;

namespace CodeKata
{
    public class ElectoralSystem
    {
        public Dictionary<string, int> DHondtMethod(string[] numbersOfParty, int[] votes, int electionMandates)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();

            int[] mundates = new int[votes.Length];
            int[] newVotes;
            for (int i = 0; i < electionMandates; i++)
            {
                int maxIndexOrginal = 0;
                int maxIndex;
                if (i == 0)
                {
                    int maxValueOrginal = votes.Max();
                    maxIndexOrginal = votes.ToList().IndexOf(maxValueOrginal);
                    mundates[maxIndexOrginal]++;


                }
                else
                {
                    newVotes = (int[])votes.Clone();

                    for (int j = 0; j < newVotes.Length; j++)
                    {
                        newVotes[j] = newVotes[j] / (mundates[j] + 1);
                    }

                    int maxValue = newVotes.Max();
                    maxIndex = newVotes.ToList().IndexOf(maxValue);
                    mundates[maxIndex]++;
                }
            }

            for (int i = 0; i < numbersOfParty.Length; i++)
            {
                result.Add(numbersOfParty[i],mundates[i]);
            }

            return result;
        }
    }
}
