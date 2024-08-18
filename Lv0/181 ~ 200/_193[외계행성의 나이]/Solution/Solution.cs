using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution1(int age)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in age.ToString())
                sb.Append((char)(int.Parse(c.ToString()) + 'a'));

            return sb.ToString();
        }

        public string solution2(int age)
        {
            string answer = "";
            while(age > 0)
            {
                answer = (char)(age % 10 + 'a') + answer;
                age /= 10;
            }
            return answer;
        }
    }
}
