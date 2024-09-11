using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(int[] ingredient)
        {
            int answer = 0;
            Stack<int> stack = new Stack<int>();

            foreach (int element in ingredient)
            {
                stack.Push(element);

                if (stack.Count >= 4 && stack.Take(4).SequenceEqual(new List<int> { 1, 3, 2, 1 }))
                {
                    for (int i = 0; i < 4; i++)
                    {
                        stack.Pop();
                    }
                    answer++;
                }
            }

            return answer;
        }
    }
}
