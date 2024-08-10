using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution1(int[] array, int n)
        {
            Array.Sort(array);
            int minDiff = Math.Abs(array[0] - n), minIdx = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int curIdx = i;
                int curDiff = Math.Abs(array[i] - n);

                if (curDiff < minDiff)
                {
                    minDiff = curDiff;
                    minIdx = curIdx;
                }
            }

            return array[minIdx];
        }

        public int solution2(int[] array, int n)
        {
            return array.OrderBy(x => x).FirstOrDefault(x => Math.Abs(x - n) == array.Min(o => Math.Abs(o - n)));
        }

        public int solution3(int[] array, int n)
        {
            return array.OrderBy(x => x).OrderBy(x => Math.Abs(x - n)).ToArray().First();
        }
    }
}
