using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution1(int[] lottos, int[] win_nums)
        {
            int[] ranking = { 6, 6, 5, 4, 3, 2, 1 };
            int correctCount = 0;
            int zeroCount = lottos.Count(x => x == 0);

            IEnumerable<int> notCorrected = win_nums.Except(lottos);

            // 모두 일치하는 경우
            if (notCorrected.Count() == 0)
                return new int[] { 1, 1 };

            correctCount = win_nums.Length - notCorrected.Count();

            int maxCorrect = correctCount + zeroCount; // 최대 일치 개수
            int minCorrect = correctCount; // 최소 일치 개수

            return new int[] { ranking[maxCorrect], ranking[minCorrect] };
        }

        public int[] solution2(int[] lottos, int[] win_nums)
        {
            int[] ranking = { 6, 6, 5, 4, 3, 2, 1 };
            int zeroCount = lottos.Count(x => x == 0);
            int correctCount = lottos.Intersect(win_nums).Count();

            int maxCorrect = correctCount + zeroCount;
            int minCorrect = correctCount;

            return new[] { ranking[maxCorrect], ranking[minCorrect] };
        }
    }
}
