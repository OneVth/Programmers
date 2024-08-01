using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution1(string n_str)
        {
            int index = 0;

            for (int i = 0; i < n_str.Length; i++)
            {
                if (n_str[i] != '0') break;
                index++;
            }

            char[] answer = new char[n_str.Length - index];

            n_str.CopyTo(index, answer, 0, n_str.Length - index);
            return new string(answer);
        }

        public string solution2(string n_str)
        {
            return int.Parse(n_str).ToString();
        }
    }
}
