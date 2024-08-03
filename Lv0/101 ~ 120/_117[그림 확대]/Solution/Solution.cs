using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string[] solution(string[] picture, int k)
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
    }
}
