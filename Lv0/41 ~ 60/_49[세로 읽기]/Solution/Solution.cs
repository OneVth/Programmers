using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution1(string my_string, int m, int c)
        {
            List<char> list = new List<char>();

            for (int i = c - 1; i < my_string.Length; i += m)
            {
                list.Add(my_string[i]);
            }

            return new string(list.ToArray());
        }

        public string solution2(string my_string, int m, int c)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < my_string.Length / m; i++)
                sb.Append(my_string[i * m + c - 1]);

            return sb.ToString();
        }
    }
}
