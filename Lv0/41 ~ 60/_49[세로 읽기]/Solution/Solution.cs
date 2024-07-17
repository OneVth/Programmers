using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution(string my_string, int m, int c)
        {
            List<char> list = new List<char>();

            for (int i = c - 1; i < my_string.Length; i += m)
            {
                list.Add(my_string[i]);
            }

            return new string(list.ToArray());
        }
    }
}
