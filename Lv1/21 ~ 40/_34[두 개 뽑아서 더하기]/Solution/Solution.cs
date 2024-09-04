using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution(int[] numbers)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    list.Add(numbers[i] + numbers[j]);
                }
            }

            return list.OrderBy(o => o).Distinct().ToArray();
        }
    }
}
