using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution(int n)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0) sb.Append("수");
                else sb.Append("박");
            }

            return sb.ToString();
        }
    }
}
