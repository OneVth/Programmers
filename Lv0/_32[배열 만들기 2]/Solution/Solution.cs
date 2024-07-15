using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution(int l, int r)
        {
            int[] answer = new int[] { };
            List<int> result = new List<int>();
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("5");

            while (queue.Count > 0)
            {
                string current = queue.Dequeue();
                int num = int.Parse(current);

                if (num > r)
                    continue;

                if (num >= l && num <= r)
                {
                    result.Add(num);
                }

                if (current.Length < r.ToString().Length)
                {
                    queue.Enqueue(current + "0");
                    queue.Enqueue(current + "5");
                }
            }

            if (result.Count == 0)
            {
                result.Add(-1);
            }

            answer = result.ToArray();
            return answer;
        }
    }
}
