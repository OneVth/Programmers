using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution(string[] seoul)
        {
            int idx = Array.IndexOf(seoul, "Kim");
            return $"김서방은 {idx}에 있다";
        }
    }
}
