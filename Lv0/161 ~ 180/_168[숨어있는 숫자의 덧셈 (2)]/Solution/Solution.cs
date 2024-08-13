using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution1(string my_string)
        {
            int answer = 0;
            char[] alpha = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            string[] array = my_string.Split(alpha);

            foreach (string s in array)
            {
                if (int.TryParse(s, out int num))
                    answer += num;
            }

            return answer;
        }

        public int solution2(string my_string)
        {
            MatchCollection matches = Regex.Matches(my_string, @"\d+");

            int totalSum = 0;

            foreach (Match match in matches)
            {
                totalSum += int.Parse(match.Value);
            }

            return totalSum;
        }
    }
}
