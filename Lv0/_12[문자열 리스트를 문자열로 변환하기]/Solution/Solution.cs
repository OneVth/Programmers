using System;
using System.Collections.Generic;
using System.Text;

namespace Solution
{
    internal class Solution
    {
        public string solution1(string[] arr)
        {
            string answer = "";

            foreach (string str in arr)
            {
                answer += str;
            }
            return answer;
        }

        public string solution2(string[] arr)
        {
            string answer = "";
            answer = String.Join("", arr);
            return answer;
        }

        public string solution3(string[] arr)
        {
            string answer = String.Concat(arr);
            return answer;
        }
    }
}
