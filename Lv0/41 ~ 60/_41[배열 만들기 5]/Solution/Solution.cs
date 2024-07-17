using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int[] solution(string[] intStrs, int k, int s, int l)
        {
            int[] answer;
            List<int> list = new List<int>();

            foreach (string str in intStrs)
            {
                char[] intChars = str.ToCharArray(s, l);
                int targetInt = int.Parse(intChars);
                if (targetInt > k) list.Add(targetInt);
            }

            answer = list.ToArray();
            return answer;
        }
    }
}
