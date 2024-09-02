using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution1(int n, int[] lost, int[] reserve)
        {
            // 학생 번호와 index 대응을 위해 n + 2개의 배열을 만듦
            // 즉, 0번, 마지막 인덱스는 Dummy
            int[] nTraining = Enumerable.Repeat(1, n + 2).ToArray();

            foreach (int i in reserve)
                nTraining[i]++;

            foreach (int i in lost)
                nTraining[i]--;

            for (int i = 1; i < nTraining.Length; i++)
            {
                if (nTraining[i] == 0)
                {
                    if (nTraining[i - 1] == 2)
                    {
                        nTraining[i - 1]--;
                        nTraining[i]++;
                    }
                    else if (nTraining[i + 1] == 2)
                    {
                        nTraining[i + 1]--;
                        nTraining[i]++;
                    }
                }
            }

            return nTraining.Count(x => x >= 1) - 2; // 더미의 개수 제거
        }

        public int solution2(int n, int[] lost, int[] reserve)
        {
            // Convert arrays to lists for easier manipulation
            List<int> lostList = lost.ToList();
            List<int> reserveList = reserve.ToList();

            // Remove students who are both in lost and reserve lists
            List<int> finalLost = lostList.Except(reserveList).ToList();
            List<int> finalReserve = reserveList.Except(lostList).ToList();

            foreach (int student in finalReserve)
            {
                if (finalLost.Contains(student - 1))
                    finalLost.Remove(student - 1);
                else if (finalLost.Contains(student + 1))
                    finalLost.Remove(student + 1);
            }

            // The number of students who can attend the gym class
            return n - finalLost.Count;
        }
    }
}
