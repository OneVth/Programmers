using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution(string[] strArr)
        {
            int answer = 0;
            Dictionary<int, List<string>> lengthGroups = new Dictionary<int, List<string>>();

            foreach (string s in strArr)
            {
                int length = s.Length;
                if (!lengthGroups.ContainsKey(length))
                {
                    lengthGroups[length] = new List<string>();
                }
                lengthGroups[length].Add(s);
            }

            foreach (List<string> list_s in lengthGroups.Values)
            {
                if (list_s.Count > answer)
                    answer = list_s.Count;
            }

            return answer;
        }
    }
}
