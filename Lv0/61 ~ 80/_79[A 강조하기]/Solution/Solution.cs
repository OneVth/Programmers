﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public string solution1(string myString)
        {
            string answer = "";
            answer = myString.ToLower();
            answer = answer.Replace('a', 'A');
            return answer;
        }

        public string solution2(string myString)
        {
            return myString.ToLower().Replace('a', 'A');
        }
    }
}
