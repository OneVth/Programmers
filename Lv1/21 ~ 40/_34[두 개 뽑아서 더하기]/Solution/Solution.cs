using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution1(int[] numbers)
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

        public int[] solution2(int[] numbers)
        {
            List<int> answerList = new List<int>();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (!answerList.Contains(numbers[i] + numbers[j]))
                        answerList.Add(numbers[i] + numbers[j]);
                }
            }

            answerList.Sort();

            return answerList.ToArray();
        }

        public int[] solution3(int[] numbers)
        {
            HashSet<int> sums = new HashSet<int>();

            for(int i = 0; i < numbers.Length - 1; i++)
            {
                for(int j = i + 1; j < numbers.Length; j++)
                {
                    sums.Add(numbers[i] + numbers[j]);
                }
            }

            return sums.OrderBy(o => o).ToArray();
        }
    }
}
