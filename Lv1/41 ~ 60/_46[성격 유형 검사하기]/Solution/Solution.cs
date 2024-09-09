using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution(string[] survey, int[] choices)
        {
            int[] score = { 0, 3, 2, 1, 0, 1, 2, 3 };
            char[] type = { 'R', 'T', 'C', 'F', 'J', 'M', 'A', 'N' };
            Dictionary<char, int> scoreForEachType = new Dictionary<char, int>();

            // Initialize
            foreach (char c in type)
            {
                scoreForEachType[c] = 0;
            }

            for (int i = 0; i < survey.Length; i++)
            {
                char cFirst = survey[i][0];
                char cLast = survey[i][1];
                int number = choices[i];

                if (choices[i] < 4)
                    scoreForEachType[cFirst] += score[number];
                else if (choices[i] > 4)
                    scoreForEachType[cLast] += score[number];
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < type.Length; i += 2)
            {
                char temp = scoreForEachType[type[i]] >= scoreForEachType[type[i + 1]] ? type[i] : type[i + 1];
                sb.Append(temp);
            }

            return sb.ToString();
        }
    }
}
