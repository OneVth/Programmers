using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string[] solution(string myStr)
        {
            string[] answer = new string[] { };
            char[] delimeters = { 'a', 'b', 'c' };

            answer = myStr.Split(delimeters).Where(w => !string.IsNullOrWhiteSpace(w)).ToArray();

            return answer.Length == 0 || answer == null ? new string[] { "EMPTY" } : answer;
        }
    }
}
