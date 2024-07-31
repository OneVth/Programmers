using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string[] solution1(string my_string)
        {
            return my_string.Split(' ').Where(w => !string.IsNullOrEmpty(w)).ToArray();
        }

        public string[] solution2(string my_string)
        {
            string[] str = my_string.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            return str;
        }

        public string[] solution3(string my_string)
        {
            return my_string.Split().Where(w => !string.IsNullOrWhiteSpace(w)).ToArray();
        }
    }
}
