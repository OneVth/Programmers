using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution1(int[] rank, bool[] attendance)
        {
            int[] topThree = rank.Where((w, index) => attendance[index]).OrderBy(o => o).Take(3).ToArray();

            int a = Array.IndexOf(rank, topThree[0]);
            int b = Array.IndexOf(rank, topThree[1]);
            int c = Array.IndexOf(rank, topThree[2]);

            return 10000 * a + 100 * b + c;
        }

        public int solution2(int[] rank, bool[] attendance)
        {
            var list = new List<(int Rank, int Index)>();
            for (int i = 0; i < rank.Length; i++)
            {
                if (!attendance[i]) continue;
                list.Add((rank[i], i));
            }

            var arr = list.OrderBy(o => o.Item1).Take(3).ToArray();
            return 10000 * arr[0].Index + arr[1].Index + arr[2].Index;
        }

        public int solution3(int[] rank, bool[] attendance)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < rank.Length; i++)
            {
                if (attendance[i])
                    dict.Add(rank[i], i);
            }
            List<int> list = dict.Keys.ToList();
            list.Sort();
            return dict[list[0]] * 10000 + dict[list[1]] * 100 + dict[list[2]];
        }
    }
}
