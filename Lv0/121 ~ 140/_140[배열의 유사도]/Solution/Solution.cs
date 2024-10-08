﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    internal class Solution
    {
        public int solution1(string[] s1, string[] s2)
        {
            int answer = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                for (int j = 0; j < s2.Length; j++)
                {
                    if (s1[i] == s2[j]) answer++;
                }
            }
            return answer;
        }

        public int solution2(string[] s1, string[] s2)
        {
            return s1.Count(x => s2.Contains(x));
        }
    }
}
