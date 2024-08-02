using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution1(string[] str_list, string ex)
        {
            return string.Join("", str_list.Where(w => !w.Contains(ex)));
        }

        public string solution2(string[] str_list, string ex)
        {
            return str_list.Where(w => !w.Contains(ex))
                .Aggregate("", (current, next) => current + next);
        }

        public string solution3(string[] str_list, string ex)
        {
            var sb = new StringBuilder();
            foreach (string str in str_list)
            {
                if (str.Contains(ex)) continue;
                sb.Append(str);
            }
            return sb.ToString();
        }
    }
}
