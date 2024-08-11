using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution(int[,] score)
        {
            int length = score.GetLength(0);
            int[] answer = new int[length];
            int[] avgArr = new int[length];
            int[] sortedArr = new int[length];

            for (int i = 0; i < length; i++)
                avgArr[i] = score[i, 0] + score[i, 1];

            // 내림차순 정렬
            sortedArr = avgArr.OrderByDescending(o => o).ToArray();

            // 등수 구하기
            for (int i = 0; i < length; i++)
                answer[i] = Array.IndexOf(sortedArr, avgArr[i]) + 1;

            return answer;
        }
    }
}
