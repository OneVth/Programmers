using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution(int age)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in age.ToString())
                sb.Append((char)(int.Parse(c.ToString()) + 'a'));

            return sb.ToString();
        }
    }
}
