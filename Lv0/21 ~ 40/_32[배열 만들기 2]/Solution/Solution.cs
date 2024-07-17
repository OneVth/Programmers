using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution1(int l, int r)
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

        public int[] solution2(int l, int r)
        {
            List<int> answer = new List<int>();

            for(int i = l; i < r; i++)
            {
                string str = i.ToString();
                if (str.Contains('1')) continue;
                if (str.Contains('2')) continue;
                if (str.Contains('3')) continue;
                if (str.Contains('4')) continue;
                if (str.Contains('6')) continue;
                if (str.Contains('7')) continue;
                if (str.Contains('8')) continue;
                if (str.Contains('9')) continue;

                answer.Add(i);
            }

            if (answer.Count == 0) answer.Add(-1);
            return answer.ToArray();
        }

        public int[] solution3(int l, int r)
        {
            int[] answer = new int[] { };

            answer = Enumerable.Range(l, r - l + 1).
                Where(x => x.ToString().
                All(y => y == '5' || y == '0')).ToArray();

            if (answer.Length <= 0)
                return new int[] { -1 };

            return answer;
        }

        public int[] solution4(int l, int r)
        {
            while (l % 5 != 0)
                ++l;

            var list = new List<int>();
            for(int i = l; i <= r; i += 5)
            {
                string str = i.ToString().Replace("0", "").Replace("5", "");
                if (string.IsNullOrEmpty(str)) list.Add(i);
            }

            return list.Count == 0 ? new int[] { -1 } : list.ToArray();
        }
    }
}
