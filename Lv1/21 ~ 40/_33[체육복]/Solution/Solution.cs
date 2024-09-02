using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(int n, int[] lost, int[] reserve)
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
    }
}
