using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution1(int[] answers)
        {
            int[] answer = { };
            int[] student1 = { 1, 2, 3, 4, 5 };
            int[] student2 = { 2, 1, 2, 3, 2, 4, 2, 5 };
            int[] student3 = { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };
            int[] repeated1, repeated2, repeated3;
            int nCount1 = 0, nCount2 = 0, nCount3 = 0;
            int length = answers.Length;

            repeated1 = Enumerable.Repeat(student1, (length / student1.Length) + 1)
                .SelectMany(x => x)
                .Take(length)
                .ToArray();

            repeated2 = Enumerable.Repeat(student2, (length / student1.Length) + 1)
                .SelectMany(x => x)
                .Take(length)
                .ToArray();

            repeated3 = Enumerable.Repeat(student3, (length / student1.Length) + 1)
                .SelectMany(x => x)
                .Take(length)
                .ToArray();

            for (int i = 0; i < length; i++)
            {
                if (repeated1[i] == answers[i])
                    nCount1++;

                if (repeated2[i] == answers[i])
                    nCount2++;

                if (repeated3[i] == answers[i])
                    nCount3++;
            }

            if (nCount1 == nCount2 && nCount2 == nCount3)
                answer = new int[] { 1, 2, 3 };
            else if (nCount1 == nCount2 && nCount1 > nCount3)
                answer = new int[] { 1, 2 };
            else if (nCount1 == nCount3 && nCount1 > nCount2)
                answer = new int[] { 1, 3 };
            else if (nCount2 == nCount3 && nCount2 > nCount1)
                answer = new int[] { 2, 3 };
            else if (nCount1 > nCount2 && nCount1 > nCount3)
                answer = new int[] { 1 };
            else if (nCount2 > nCount1 && nCount2 > nCount3)
                answer = new int[] { 2 };
            else if (nCount3 > nCount1 && nCount3 > nCount2)
                answer = new int[] { 3 };

            return answer;
        }

        public int[] solution2(int[] answers)
        {
            int[] nRules1 = { 1, 2, 3, 4, 5 };
            int[] nRules2 = { 2, 1, 2, 3, 2, 4, 2, 5 };
            int[] nRules3 = { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };
            int[] nScores = new int[3];
            
            for(int i = 0; i < answers.Length; i++)
            {
                if (answers[i] == nRules1[i % nRules1.Length])
                    nScores[0]++;

                if (answers[i] == nRules2[i % nRules2.Length])
                    nScores[1]++;

                if (answers[i] == nRules3[i % nRules3.Length])
                    nScores[2]++;
            }

            List<int> result = new List<int>();
            for(int i = 0; i < nScores.Length; i++)
            {
                if (nScores[i] == nScores.Max())
                    result.Add(i + 1);
            }

            return result.ToArray();
        }
    }
}
