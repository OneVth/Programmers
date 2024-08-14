using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution1(string s)
        {
            int answer = 0;
            string[] tokens = s.Split(" ");

            for (int i = 0; i < tokens.Length; i++)
            {
                if ("Z" == tokens[i])
                    answer -= int.Parse(tokens[i - 1]);
                else
                    answer += int.Parse(tokens[i]);
            }
            return answer;
        }

        public int solution2(string s)
        {
            var list = s.Split(' ').ToList();

            while (list.Contains("Z"))
            {
                list.RemoveRange(list.IndexOf("Z") - 1, 2);
            }

            return list.Sum(x => Convert.ToInt32(x)); ;
        }
    }
}
