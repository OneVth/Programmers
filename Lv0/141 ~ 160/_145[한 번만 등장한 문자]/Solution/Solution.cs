using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution1(string s)
        {
            List<char> list = new List<char>();

            foreach (char c in s)
            {
                if (s.IndexOf(c) == s.LastIndexOf(c))
                    list.Add(c);
            }

            list.Sort();
            return new string(list.ToArray());
        }

        public string solution2(string s)
        {
            return string.Concat(s.Where(w => s.Count(c => c == w) == 1).OrderBy(o => o));
        }

        public string solution3(string s)
        {
            string answer = "";
            for(char ch = 'a'; ch <= 'z'; ch++)
            {
                if(s.Split(ch).Length == 2)
                {
                    answer += ch;
                }
            }

            return answer;
        }
    }
}
