using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution(string s)
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
    }
}
