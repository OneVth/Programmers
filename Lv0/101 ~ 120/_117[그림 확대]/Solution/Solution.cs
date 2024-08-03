using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string[] solution1(string[] picture, int k)
        {
            StringBuilder sb = new StringBuilder();
            List<string> list = new List<string>();

            foreach (string s in picture)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    for (int j = 0; j < k; j++)
                    {
                        sb.Append(s[i]);
                    }
                }
                for (int j = 0; j < k; j++)
                {
                    list.Add(sb.ToString());
                }
                sb.Clear();
            }

            return list.ToArray();
        }

        public string[] solution2(string[] picture, int k)
        {
            var result = new List<string>();

            foreach (var line in picture)
            {
                var expandedLine = string.Concat(line.Select(c => new string(c, k)));
                for (int i = 0; i < k; i++)
                {
                    result.Add(expandedLine);
                }
            }
            return result.ToArray();
        }
    }
}
